var marksPerStudent = new Dictionary<string, double>()
{
    { "Ivanov", 10.4},
    { "Petrova", 9.2},
    { "Sidorenko", 6.9},
    { "AIrpinova", 11.2},
    { "Petrusenko", 8.2},
    { "Kolubko", 7.8},
    { "Kravchenko", 8.7},
    { "Brakova", 5.0},
    { "Arbuzov", 5.9},
    { "Avarin", 6.9},
    { "Latunin", 8.3},
    { "Mirosin", 4.9},
    { "Gladchenko", 7.7},
    { "Bruskov", 9.8},
};

var excellentStudents = marksPerStudent.Where(s => s.Value > 10.0).OrderBy(s=>s.Key);

Console.WriteLine("List of students with mark more than 10:");
foreach (var student in excellentStudents)
{
    Console.WriteLine($"{student.Key}:{student.Value}");
}

var fineStudents = marksPerStudent.Where(s => s.Value >= 7.0).Where(s => s.Value <= 10.0).OrderBy(s => s.Key);

Console.WriteLine("\nList of students with mark 7-10:");
foreach (var student in fineStudents)
{
    Console.WriteLine($"{student.Key}:{student.Value}");
}

var otherStudents = marksPerStudent.Where(s => s.Value <7.0).OrderBy(s => s.Key);

Console.WriteLine("\nList of students with mark less then 7:");
foreach (var student in otherStudents)
{
    Console.WriteLine($"{student.Key}:{student.Value}");
}

var retestforStudents = marksPerStudent.Where(s => s.Value < 6.0).OrderBy(s => s.Key);

Console.WriteLine("\nList of students that need to retake the exam:");
foreach (var student in retestforStudents)
{
    Console.WriteLine($"{student.Key}:{student.Value}");
}

var studentsNoSertificate = marksPerStudent.Where(s => s.Value < 5.0);
Console.WriteLine("\nList of students' names that will NOT receive a certificate:");
foreach (var student in studentsNoSertificate)
{
    Console.WriteLine(student.Key);
}

var superExcellentSudent= marksPerStudent.Where(s => s.Value > 11.0);
int countSuperExcellentSt= superExcellentSudent.Count();
int countExcellentSt = excellentStudents.Count();
Console.WriteLine($"\nWe have {countExcellentSt} excellent student(s). They have mark more than 10. \nWe have {countSuperExcellentSt} super excellent student(s). They have mark more than 11.");