using static System.Console;
using Speed_converter;

float input_value;
while (true)
{
    do
    {
        Clear();
        WriteLine("-_-_-_Convert Speed Units_-_-_-");
        WriteLine("Insert the value that you wish to convert:");
    } while (!float.TryParse(ReadLine(), out input_value));

    WriteLine("the unit that you have typed is in:");
    WriteLine("a. m/s");
    WriteLine("b. km/t");
    WriteLine("c. mph");
    WriteLine("d. knots");
    string from_unit = ReadKey(true).KeyChar.ToString();
    Clear();
    WriteLine("The unit you want to convert it to is:");
    if (from_unit != "a")
        WriteLine("a. m/s");
    if (from_unit != "b")
        WriteLine("b. km/t");
    if (from_unit != "c")
        WriteLine("c. mph");
    if (from_unit != "d")
        WriteLine("d. knots");
    string to_unit = ReadKey(true).KeyChar.ToString();
    Clear();
    WriteLine(convert_units(input_value, from_unit, to_unit));

    ReadKey();
}

static string convert_units(float input_value, string from_unit, string to_unit)
{
    float result = 0;
    string unit = "";
    switch (from_unit)
    {
        // m/s
        case "a":
            if (to_unit == "a")
                result = input_value;
            else if (to_unit == "b")
                result = ms.to_kmph(input_value);
            else if (to_unit == "c")
                result = ms.to_mph(input_value);
            else if (to_unit == "d")
                result = ms.to_knots(input_value);
            unit = ms.name;
            break;

        // km/t
        case "b":
            if (to_unit == "a")
                result = kmh.to_SI_unit(input_value);
            else if (to_unit == "b")
                result = input_value;
            else if (to_unit == "c")
                result = ms.to_mph(kmh.to_SI_unit(input_value));
            else if (to_unit == "d")
                result = ms.to_knots(kmh.to_SI_unit(input_value));
            unit = kmh.name;
            break;

        // mph
        case "c":
            if (to_unit == "a")
                result = mph.to_SI_unit(input_value);
            else if (to_unit == "b")
                result = ms.to_kmph(mph.to_SI_unit(input_value));
            else if (to_unit == "c")
                result = input_value;
            else if (to_unit == "d")
                result = ms.to_knots(mph.to_SI_unit(input_value));
            unit = mph.name;
            break;

        // knots
        case "d":
            if (to_unit == "a")
                result = knots.to_SI_unit(input_value);
            else if (to_unit == "b")
                result = ms.to_kmph(knots.to_SI_unit(input_value));
            else if (to_unit == "c")
                result = ms.to_mph(knots.to_SI_unit(input_value));
            else if (to_unit == "d")
                result = input_value;
            unit = knots.name;
            break;
    }
    return $"{result} {unit}";
}