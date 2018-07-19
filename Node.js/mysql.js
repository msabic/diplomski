const mysql      = require('mysql');
const md5 = require('md5');
const generator = require('generate-password');

const connection = mysql.createConnection({
  host     : 'localhost',
  user     : 'root',
  password : '12345',
  database : 'prisustvo_studenata'
});
 
connection.connect();
const test=function(){ 
console.log(md5('mijo'));
};

module.exports={
    test:test
}
