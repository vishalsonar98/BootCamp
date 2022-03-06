function externalAlert()
{
    alert("External alert function");
}
function externalConfirm()
{
    if(confirm("are you sure...."))
            {
                alert("Ok you are in");
            }
            else
            {
                alert("You need to work more");
            }
}
function externalPrompt()
{
    var f1=prompt("Enter your first name");
    var f2=prompt("Enter your last name");
    alert(f1+" "+f2);
}