'use strict';

var chatDb = require('./chat-db.js');

chatDb.init('localhost:27017/chat');

 /*
chatDb.registerUser({
    username: 'pesho', 
    password: '123'});
chatDb.registerUser({
    username: 'vankata', 
    password: '123'});

chatDb.sendMessage({
    sender: 'pesho',
    receiver: 'vankata',
    text: 'Ko staa?'
});
chatDb.sendMessage({
    sender: 'vankata',
    receiver: 'pesho',
    text: 'Pri tebe?'
});
*/

console.log('Messages: ')
chatDb.getMessages('pesho', 'vankata', function(err, result){
    if(err) {
        console.error(err);
    }
    console.log(result);
});