double earthTime;
double ageInSeconds = 1000000000;

double marsOrbitalPeriod = 1.8808158;
double earthPeriod = 1.0;
double mercuryOrbitalPeriod = 0.2408467;
double venusOrbitalPeriod = 0.61519726;
double jupiterOrbitalPeriod = 11.862615;
double saturnOrbitalPeriod = 29.447498;
double uranusOrbitalPeriod = 84.016846;
double neptuneOrbitalPeriod = 164.79132;


EarthAgeConverter(365.25, 24, 60, 60, out earthTime);
AgeCalc(ageInSeconds, earthTime, earthPeriod, Planets.Earth);
AgeCalc(ageInSeconds, earthTime, marsOrbitalPeriod, Planets.Mars);
AgeCalc(ageInSeconds, earthTime, mercuryOrbitalPeriod,Planets.Mercury);
AgeCalc(ageInSeconds, earthTime, venusOrbitalPeriod,Planets.Venus);
AgeCalc(ageInSeconds, earthTime, jupiterOrbitalPeriod,Planets.Jupiter);
AgeCalc(ageInSeconds, earthTime, saturnOrbitalPeriod,Planets.Saturn);
AgeCalc(ageInSeconds, earthPeriod, uranusOrbitalPeriod,Planets.Uranus);
AgeCalc(ageInSeconds, earthTime, neptuneOrbitalPeriod, Planets.Neptune);


double EarthAgeConverter(double days, double hours, double min, double second, out double earthTime)
{
    earthTime = days * hours * min * second;
    Console.WriteLine($"Seconds: {earthTime}");
    return earthTime;
}
void AgeCalc (double timeInSecond, in double earthOrbitalPeriod, double orbitalPeriod, Planets planet)
{
    double result = planet switch
    {
        Planets.Earth => timeInSecond / earthOrbitalPeriod * earthPeriod,
        Planets.Mars => timeInSecond / (earthOrbitalPeriod * marsOrbitalPeriod),
        Planets.Saturn => timeInSecond / (earthOrbitalPeriod * saturnOrbitalPeriod),
        Planets.Mercury => timeInSecond / (earthOrbitalPeriod * mercuryOrbitalPeriod),
        Planets.Uranus => timeInSecond / (earthOrbitalPeriod * uranusOrbitalPeriod),
        Planets.Jupiter => timeInSecond / (earthOrbitalPeriod * jupiterOrbitalPeriod),
        Planets.Neptune => timeInSecond / (earthOrbitalPeriod * neptuneOrbitalPeriod),
        Planets.Venus => timeInSecond / (earthOrbitalPeriod * venusOrbitalPeriod),
        _ => throw new NotImplementedException("Invalid input")
    };
    Console.WriteLine($"{planet} Age: {result}");
}

AgeSpace timeCheck = new (1000000000);

System.Console.WriteLine($"Earth Time: {timeCheck.OnEarth()}");
System.Console.WriteLine($"Mercury Time: {timeCheck.OnMercury()}");


public enum Planets {Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune};


public class AgeSpace(int Seconds)
{
    private readonly double seconds = Seconds;

    public double OnEarth() => seconds / 31557600;
    public double OnMercury() => OnEarth() / 0.2408467;
    public double OnVenus() => OnEarth() / 0.61519726;
    public double OnMars() => OnEarth() / 1.8808158;
    public double OnJupiter() => OnEarth() / 11.862615;
    public double OnSaturn() => OnEarth() / 29.447498;
    public double OnUranus() => OnEarth() / 84.016846;
    public double OnNeptune() => OnEarth() / 164.79132;
}