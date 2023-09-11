using animalsPractic;
cat[] cats =
{
    new cat("kity",System.Drawing.Color.Aqua),
    new cat("mestan",System.Drawing.Color.Black ),
    new cat("girlfid",System.Drawing.Color.Blue ),
    new cat("tom",System.Drawing.Color.Brown),
    new cat("yaramaz",System.Drawing.Color.Aqua)
};

dog[] dogs =
{
    new dog("bethoven",System.Drawing.Color.Coral),
    new dog("bad_dog",System.Drawing.Color.Coral),
    new dog("hav-hav",System.Drawing.Color.Coral),
    new dog("mirt_usaq",System.Drawing.Color.Coral)
};


ship[] ships =
{
    new ship("new_ship 1",System.Drawing.Color.Coral),
    new ship("new_ship 2",System.Drawing.Color.Coral),
    new ship("new_ship 3",System.Drawing.Color.Coral),
    new ship("new_ship 4",System.Drawing.Color.Coral),
};

Animal_abstract[][] animals =
{
    cats,
    dogs,
    ships
};

foreach (var item in animals)
{
    foreach (var item2 in item)
        item2.eat();
}