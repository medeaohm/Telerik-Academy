(function () {
    var http = require('http'),
        fs = require('fs'),
        path = require('path'),
        multiparty = require('multiparty'),
        handlebars = require('handlebars'),
        dataFiles = {},
        files = [],
        mimeTypes = {
            '.js': 'text/javascript',
            '.html': 'text/html',
            '.css': 'text/css'
        },
        port = 3000;
    
    http.createServer(function (request, response) {
        var lookup = path.basename(decodeURI(request.url)) || 'index.html',
            dir = '';
        
        switch (lookup) {
            case 'jquery.js': dir = './node_modules/jquery/dist/'; break;
            case 'bootstrap.css': dir = './node_modules/bootstrap/dist/css/'; break;
            case 'bootstrap.js': dir = './node_modules/bootstrap/dist/js/'; break;
            case 'handlebars.js': dir = './node_modules/handlebars/dist/'; break;
            default: dir = './views/';
        }
        
        fs.readdir('./files/', function (err, data) {
            dataFiles = {
                files: data
            };
            files = data;
        });
        
        if (request.url === '/upload') {
            var form = new multiparty.Form({ uploadDir: './files/', autoFiles: true });
    
            form.parse(request, function (err, field, file) {
                var fileName = file.upload[0].originalFilename;
                files.push(fileName);
                fs.writeFile(fileName, file, function (err) {
                    if (err) {
                        console.log('File no found!');
                    }
                    else {
                        console.log('File saved!');
                    }
                });

            });

            response.writeHead(301, { location: '/' });
            response.end();
        }
        
        if (request.url.indexOf('download') > -1) {
            var fileName = request.url.substring(request.url.lastIndexOf('/') + 1);
            var fileNamePath = './files/' + fileName;
            console.log(fileName);
            fs.readFile(fileNamePath, function (err, data) {
                fs.writeFile('./downloads/' + fileName, data, function (err) {
                    if (err) throw err;
                    console.log('File downloaded!');
                });
            });

            response.writeHead(301, { location: '/' });
            response.end();
        }
        
        var file = dir + lookup;
        fs.exists(file, function (exists) {
            if (exists) {
                fs.readFile(file, function (err, data) {
                    if (err) {
                        response.writeHead(500);
                        response.end('Server Error!');
                        return;
                    }
                    
                    var html = data;
                    if (lookup === 'index.html') {
                        var template = handlebars.compile(data.toString());
                        html = template(dataFiles);
                    }
                    
                    var headers = { 'Content-type': mimeTypes[path.extname(lookup)] };
                    response.writeHead(200, headers);
                    response.end(html);
                });
                return;
            }
            else {
                response.writeHead(404);
                response.end();
            }
        });
    }).listen(port);
    
    console.log('Server running on port ' + port);
}());