var express = require('express');
var router = express.Router();
const { PythonShell } = require('python-shell');



/* GET home page. */
router.get('/', function(req, res ) {

  res.render('index');

});
router.post('/', function(req,res){
  console.log(req.body.userid); //  req.body.userid를 받아옴

  var pyshell = new PythonShell("all_data.py");
  pyshell.send(Buffer.from(req.body.userid).toString('base64'));//the problem function

  pyshell.on('message', function (row) {
    // received a message sent from the Python script (a simple "print" statement)

    console.log(row);
    pyshell.kill(9);
    return  res.render('show', { userid:req.body.userid, data:JSON.parse(row)});


  });

// end the input stream and allow the process to exit
  pyshell.end(function (err,) {
    if (err){
      throw err;
    };

    console.log('finished');
  });

});

router.get('show', function (req,res){


    console.log(row);
    res.render('show' ,{userid:req.body.userid, data:row});


});
module.exports = router;
