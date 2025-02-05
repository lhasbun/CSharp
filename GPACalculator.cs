string studentName = "Sophia Johnson";
/*
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;
*/
string[] courseNames = new string[5] {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"};
int[] courseCredits = new int[5] {3, 3, 4, 4, 3};  // English101=3, Algebra101=3, Biology101=4, ComputerScienceI=4, Psychology101=3
int[] courseGrades = new int[5] {4, 3, 2, 1, 0}; // A=4, B=3, C=2, D=1, F=0
int[] studentGrades = new int[] {courseGrades[0], courseGrades[1], courseGrades[1], courseGrades[1], courseGrades[0]};

decimal gpa = CalculateGPA(studentGrades, courseCredits);

Console.WriteLine($"Student: {studentName}\n\nCourse\t\t\t\tGrade\tCredit Hours\n{courseNames[0]}\t\t\t{studentGrades[0]}\t\t{courseCredits[0]}\n{courseNames[1]}\t\t\t{studentGrades[1]}\t\t{courseCredits[1]}\n{courseNames[2]}\t\t\t{studentGrades[2]}\t\t{courseCredits[2]}\n{courseNames[3]}\t{studentGrades[3]}\t\t{courseCredits[3]}\n{courseNames[4]}\t\t{studentGrades[4]}\t\t{courseCredits[4]}\n\nFinal GPA:\t\t\t{gpa}");

static decimal CalculateGPA(int[] studentGrades, int[] courseCredits){
    int totalCreditHours = 0;
    int totalGradePoints = 0;
    decimal gpa = 0.0m;

    for(int i = 0; i < courseCredits.Length; i++){
        totalCreditHours += courseCredits[i];
    }

    for(int i = 0; i < studentGrades.Length; i++){
        totalGradePoints += studentGrades[i] * courseCredits[i];
    }

    gpa = (decimal)totalGradePoints / totalCreditHours;
    gpa = Math.Round(gpa, 2);

    return gpa;
};