'use strict';

var mongoose = require('mongoose');
var User = require('./models/user');
var Message = require('./models/message');

function init(connectionString) {
    mongoose.connect(connectionString);
    var db = mongoose.connection;
    
    db.on('error', console.error.bind(console, 'Connection error: '));
    db.once('open', function(error) {
        if (error) {
            console.error(error.message);
        }
        
        console.log('Mongoose connected to: ' + connectionString);
    });
}  
 
function registerUser(user) {
    var newUser = new User({
        username: user.username,
        password: user.password
    });
    
    return newUser.save(function(err, result) {
        if (err) {
            return err;
        }
        return result;
    });
}

function sendMessage(message) {
    User.findOne({username: message.sender}, function(err, result){
        var sender= result;
        
        User.findOne({username: message.receiver}, function(err, result){
            var receiver = result;
            
            var newMessage = new Message({
                sender: sender._id,
                receiver: receiver._id,
                text: message.text
            });
            
            newMessage.save(function(err, result){
                if(err) {
                    return err;
                }
                return result;
            });
        });
    });
}

function getMessages(sender, receiver, callback) {
    var query = User.findOne({username: sender}, function(err, result){
        var sender = result._id;
        
        User.findOne({username: receiver}, function(err, result){
            var receiver = result._id;
            
            Message
                .find()
                .where('sender').in([sender, receiver])
                .where('receiver').in([sender, receiver])
                .populate('sender, receiver')
                .exec(callback);
        });
    });
    return query;
}
    
module.exports = {
  init: init,
  registerUser: registerUser,
  sendMessage: sendMessage,
  getMessages: getMessages
};
    