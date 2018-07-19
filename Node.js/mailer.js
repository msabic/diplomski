
const nodemailer = require('nodemailer');

const sendMail = function (sendTo, subject, text, htmlText) {
    // Generate test SMTP service account from ethereal.email
    // Only needed if you don't have a real mail account for testing
    nodemailer.createTestAccount((err) => {

        // create reusable transporter object using the default SMTP transport
        let transporter = nodemailer.createTransport({
            service: 'gmail',
            auth: {
                user: 'mijosabic94@gmail.com', // generated ethereal user
                pass: 'M21697088i.'  // generated ethereal password
            }
        });

        // setup email data with unicode symbols
        let mailOptions = {
            from: 'mijosabic94@gmail.com', // sender address
            to: sendTo, // list of receivers
            subject: subject, // Subject line
            text: text, // plain text body
            html: htmlText // html body
        };

        // send mail with defined transport object
        transporter.sendMail(mailOptions, (error, info) => {
            if (error) {
                return console.log(error);
            }
            console.log('Message sent: %s', info.messageId);
            // Preview only available when sending through an Ethereal account
            console.log('Preview URL: %s', nodemailer.getTestMessageUrl(info));

            // Message sent: <b658f8ca-6296-ccf4-8306-87d57a0b4321@example.com>
            // Preview URL: https://ethereal.email/message/WaQKMgKddxQDoou...
        });
    });
}

module.exports = {
    sendMail: sendMail
}
