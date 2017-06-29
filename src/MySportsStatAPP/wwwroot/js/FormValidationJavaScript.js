function MyFormValidation()
{
    for (var i = 0; i < MyForm.elements.length; i++) {
        if(MyForm.elements[i].className=="required" && MyForm.elements[i].value.length==0)
        {
            alert('Please fill in all the required fields "*"');
            return false;
        }
    }

}