
// a nullable int
int? temperature = 77;


// if the int has value, do this
if (temperature.HasValue){
    Console.WriteLine("It is {0} degrees outside today", temperature.ToString());
    // otherwise do this
}else {
    Console.WriteLine("There is no reading. Perhaps a sensor failed?");
}