List<string> colors = [
  "bisque",
  "darkseagreen",
  "mediumorchid",
  "slateblue",
  "mistyrose",
  "lawngreen",
  "olive",
  "darkslateblue",
  "sienna",
  "plum",
  "peru",
  "cornsilk",
  "lightslategrey",
  "maroon",
  "chartreuse",
  "magenta",
  "olivedrab",
  "salmon",
  "dimgray",
  "papayawhip",
  "gainsboro",
  "darkorange",
  "lavender",
  "tomato",
  "rebeccapurple",
  "lightgrey",
  "greenyellow",
  "aquamarine",
  "navajowhite",
  "saddlebrown",
  "linen",
  "moccasin",
  "lemonchiffon",
  "orchid",
  "limegreen",
  "wheat",
  "snow",
  "mediumturquoise",
  "firebrick",
  "ivory",
  "mediumseagreen",
  "dimgrey",
  "seashell",
  "navy",
  "deepskyblue",
  "orangered",
  "lavenderblush",
  "lightsteelblue",
  "brown",
  "green",
  "yellowgreen",
  "darkgray",
  "floralwhite",
  "blue",
  "darkblue",
  "deeppink",
  "peachpuff",
  "indigo",
  "lightblue",
  "forestgreen",
  "whitesmoke",
  "lightsalmon",
  "palegreen",
  "lime",
  "fuchsia",
  "darkolivegreen",
  "darkviolet",
  "chocolate",
  "aliceblue",
  "gold",
  "turquoise",
  "ghostwhite",
  "grey",
  "powderblue",
  "sandybrown",
  "mintcream",
  "slategrey",
  "mediumvioletred",
  "rosybrown",
  "darkgoldenrod",
  "blueviolet",
  "slategray",
  "darkslategrey",
  "paleturquoise",
  "darkgreen",
  "coral",
  "lightyellow",
  "beige",
  "lightcyan",
  "dodgerblue",
  "lightgray",
  "black",
  "skyblue",
  "orange",
  "aqua",
  "purple",
  "blanchedalmond",
  "teal",
  "hotpink",
  "darkcyan",
  "lightslategray",
  "darkslategray",
  "mediumaquamarine",
  "midnightblue",
  "goldenrod",
  "cyan",
  "steelblue",
  "mediumpurple",
  "honeydew",
  "mediumslateblue",
  "lightgreen",
  "seagreen",
  "antiquewhite",
  "darkgrey",
  "darkturquoise",
  "thistle",
  "lightskyblue",
  "silver",
  "indianred",
  "crimson",
  "lightgoldenrodyellow",
  "lightpink",
  "darkmagenta",
  "burlywood",
  "tan",
  "darkorchid",
  "darkkhaki",
  "cornflowerblue",
  "palevioletred",
  "violet",
  "yellow",
  "mediumspringgreen",
  "oldlace",
  "springgreen",
  "azure",
  "white",
  "cadetblue",
  "royalblue",
  "khaki",
  "lightcoral",
  "lightseagreen",
  "darkred",
  "pink",
  "darksalmon",
  "mediumblue",
  "red",
  "gray",
  "palegoldenrod"
];

// Retrieve a color
// Console.WriteLine(colors[3]); // slateblue

// Add a color
// colors.Add("bluegreen");

// Sort colors
// colors.Sort();

// Remove a color
// colors.Remove("aliceblue");

// Display colors
// Console.WriteLine();
// Console.WriteLine(string.Join("\n", colors));

// Display colors in alpha order
void Show (List<string> colors) 
{
  colors.Sort();
  Console.WriteLine();
  Console.WriteLine(string.Join("\n", colors));
}

// Add a color requested by user
void Add ()
{
  Console.WriteLine("\nEnter the color would you like to add:");
  string? color = Console.ReadLine();
  if (!string.IsNullOrEmpty(color))
  {
    if (colors.Contains(color))
    {
      Console.WriteLine($"\n{color} has already been added to the list");
    }
    else
    {
      colors.Add(color);
      Console.WriteLine($"\n{color} has been added to the list");
    }
  }
}

// remove color requested by user
void Remove ()
{
  Console.WriteLine("\nEnter the color would you like to remove:");
  string? color = Console.ReadLine();
  if (!string.IsNullOrEmpty(color))
  {
    if (!colors.Contains(color))
    {
      Console.WriteLine($"\n{color} could not be found in the list.");
    }
    else
    {
      colors.Remove(color);
      Console.WriteLine($"\n{color} has been remove from the list");
    }
  }
}

// search colors based on user-provided terms
void Search () 
{
  Console.WriteLine("\nEnter your search term:");
  string? query = Console.ReadLine();

  if (!string.IsNullOrEmpty(query))
  {
    var filtered = colors.FindAll(color => color.ToLower().Contains(query.ToLower()));
    if (filtered.Count > 0) 
    {
      Show(filtered);
    }
    else
    {
      Console.WriteLine("\nNo colors matched the search term.");
    }
  }
}

bool isActive = true;

while(isActive)
{
  Console.WriteLine("\nChoose a command:");
  Console.WriteLine("1 - Show all colors");
  Console.WriteLine("2 - Add a color");
  Console.WriteLine("3 - Remove a color");
  Console.WriteLine("4 - Search colors");
  Console.WriteLine("5 - Exit");

  bool isValid = int.TryParse(Console.ReadLine(), out int command);

  switch (command)
  {
    case 1:
      Show(colors);
      break;
    case 2:
      Add();
      break;
    case 3:
      Remove();
      break;
    case 4:
      Search();
      break;
    case 5:
      isActive = false;
      break;
    default:
      Console.WriteLine("Not a valid command.");
      break;
  }
}