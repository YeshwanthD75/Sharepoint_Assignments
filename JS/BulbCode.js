function changeImage()
{
    element=document.getElementById('myimage')
    if(element.src.match("pic_bulbon.gif"))
    {
        element.src="pic_bulboff.gif";
    }
    else
    {
        element.src="pic_bulbon.gif";
    }
}