function validateEmail($email) {
    var emailReg = /^([\w-\.]+@([\w-]+\.)+[\w-]{2,4})?$/;
    return emailReg.test( $email );
}
$(document).ready(function() 
{
    $("#register").click(function() 
    {
        var name = $("#name").val();
        var email = $("#email").val();
        var password = $("#password").val();
        var cpassword = $("#cpassword").val();
        if (name == '' || email == '' || password == '' || cpassword == '') 
        {
            alert("Please fill all fields...!!!!!!");
        } 
        else if ((name.length) < 5 || (name.length) > 30) 
        {
            alert("Invalid Name");
        } 
        else if(!validateEmail(email)) 
        {
            alert("Invalid Email")
        }
        else if ((password.length) < 8) 
        {
            alert("Password should atleast 8 character in length...!!!!!!");
        } 
        else if (!(password).match(cpassword)) 
        {
            alert("Your passwords don't match. Try again?");
        }
        else{
            window.location.href = "out.html";
        }
    });
});