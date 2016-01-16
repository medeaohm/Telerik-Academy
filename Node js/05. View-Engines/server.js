'use strict';

var PORT = 3333;

var express = require('express');
var path = require('path');
var sampleData = require('./data/sampleData');

var server = express();

server.set('view engine', 'jade');
server.set('views', path.join(__dirname, 'views'));

server.get('/*', function(req, res) {
    res.render(req.url.replace('/', ''), sampleData);
});

server.listen(PORT, function(){
    console.log('Server is up and running on port', PORT);
});
