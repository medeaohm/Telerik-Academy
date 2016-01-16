'use strict';

var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var messageSchema = new Schema({
    sender: {
        type: Schema.ObjectId,
        ref: 'User'
    },
    receiver: {
        type: Schema.ObjectId,
        ref: 'User'
    },
    text: String
});

var Message = mongoose.model('Message', messageSchema);
module.exports = Message;