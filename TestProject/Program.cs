using System.Runtime.Intrinsics.X86;

public class Program{
    public static void Main(){

        // Initialize variables - graded assignments 
        string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

        int currentAssignments = 5;

        int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
        int[] andrewScores = [92, 89, 81, 96, 90, 89];
        int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
        int[] loganScores = [90, 95, 87, 88, 96, 96];
        int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
        int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
        int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
        int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];  

        int[][] studentGrades = [sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores];

        // Calculate the sum of all the students' scores


        // Calculate the sums of all the students' scores, assign to int array
        decimal[] studentSums = SumGrades(studentGrades, currentAssignments);

        // Calculate the average of all the students' scores, assign to decimal array
        decimal[] studentScores =
            [
                Math.Round(studentSums[0]/ currentAssignments, 1),
                Math.Round(studentSums[1]/ currentAssignments, 1),
                Math.Round(studentSums[2]/ currentAssignments, 1),
                Math.Round(studentSums[3]/ currentAssignments, 1),
                Math.Round(studentSums[4]/ currentAssignments, 1),
                Math.Round(studentSums[5]/ currentAssignments, 1),
                Math.Round(studentSums[6]/ currentAssignments, 1),
                Math.Round(studentSums[7]/ currentAssignments, 1),
            ];

        // Calculate the letter grades of all the students' scores, assign to string array     
        string[] studentLetterGrades = GetLetterGrade(studentScores);

        Console.WriteLine($"Student\t\tGrade\n");


        foreach(string student in studentNames){
            Console.WriteLine($"{student}:\t\t{studentScores[Array.IndexOf(studentNames, student)]}\t{studentLetterGrades[Array.IndexOf(studentNames, student)]}");
        }

        // Console.WriteLine("Sophia:\t\t{studentScores[0]}\t{studentLetterGrades[0]}\nAndrew:\t\t{studentScores[1]}\t{studentLetterGrades[1]}");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

    }
    // Function to calculate the sum of all the students' scores
    public static decimal[] SumGrades(int[][] studentGrades, int numAssignments, int index = 0){

        decimal[] studentSums = new decimal[studentGrades.Length];

        foreach(int[] student in studentGrades){

            decimal sum = 0;
            int i = 0;

            foreach(int grade in student){

                if(i >= numAssignments){
                    sum += grade * 0.10m;
                }else{
                    sum += grade;
                }

                i++;

            }

            studentSums[index] = Math.Round(sum, 1);
            index++;

        }

        return studentSums;
    }

    // Function to calculate the letter grade of all the students' scores
    public static string[] GetLetterGrade(decimal[] studentScores, int index = 0){

        string[] letterGrades = ["A", "B", "C", "D", "F"];
        string[] letterGradeMods = ["+", "-"];

        string[] studentLetterGrades = new string[studentScores.Length];
        
        foreach(decimal score in studentScores){

            if(score >= 97){
                studentLetterGrades[index] = letterGrades[0] + letterGradeMods[0];
            }else if(score >= 93){
                studentLetterGrades[index] = letterGrades[0];
            }else if(score >= 90){
                studentLetterGrades[index] = letterGrades[0] + letterGradeMods[1];
            }else if(score >= 87){
                studentLetterGrades[index] = letterGrades[1] + letterGradeMods[0];
            }else if(score >= 83){
                studentLetterGrades[index] = letterGrades[1];
            }else if(score >= 80){
                studentLetterGrades[index] = letterGrades[1] + letterGradeMods[1];
            }else if(score >= 77){
                studentLetterGrades[index] = letterGrades[2] + letterGradeMods[0];
            }else if(score >= 73){
                studentLetterGrades[index] = letterGrades[2];
            }else if(score >= 70){
                studentLetterGrades[index] = letterGrades[2] + letterGradeMods[1];
            }else if(score >= 67){
                studentLetterGrades[index] = letterGrades[3] + letterGradeMods[0];
            }else if(score >= 63){
                studentLetterGrades[index] = letterGrades[3];
            }else if(score >= 60){
                studentLetterGrades[index] = letterGrades[3] + letterGradeMods[1];
            }else{
                studentLetterGrades[index] = letterGrades[4];
            }

            index++;

        }

        return studentLetterGrades;

    }

}