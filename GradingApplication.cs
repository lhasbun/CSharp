// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int[] sophia = new int[] {sophia1, sophia2, sophia3, sophia4, sophia5};
int[] nicolas = new int[] {nicolas1, nicolas2, nicolas3, nicolas4, nicolas5};
int[] zahirah = new int[] {zahirah1, zahirah2, zahirah3, zahirah4, zahirah5};
int[] jeong = new int[] {jeong1, jeong2, jeong3, jeong4, jeong5};

int[][] students = new int[][] {sophia, nicolas, zahirah, jeong};

string[] letterGrades = {"A", "B", "C", "D", "F"};

decimal sophiaAverage = 0;
decimal nicolasAverage = 0;
decimal zahirahAverage = 0;
decimal jeongAverage = 0;

string sophiaLetterGrade = "";
string nicolasLetterGrade = "";
string zahirahLetterGrade = "";
string jeongLetterGrade = "";   

for(int i = 0; i < students.Length; i++){
    for(int j = 0; j < currentAssignments; j++){
        if(i == 0){
            sophiaAverage += students[i][j];
        } else if (i == 1){
            nicolasAverage += students[i][j];
        } else if (i == 2){
            zahirahAverage += students[i][j];
        } else if (i == 3){
            jeongAverage += students[i][j];
        };
    };
};

sophiaAverage = (decimal) sophiaAverage / currentAssignments;
sophiaAverage = Math.Round(sophiaAverage, 1);
sophiaLetterGrade = getLetterGrade(sophiaAverage, letterGrades);
string sophiaAvgStr = sophiaAverage.ToString("0.0");

nicolasAverage = (decimal) nicolasAverage / currentAssignments;
nicolasAverage = Math.Round(nicolasAverage, 1);
nicolasLetterGrade = getLetterGrade(nicolasAverage, letterGrades);
string nicolasAvgStr = nicolasAverage.ToString("0.0");

zahirahAverage = (decimal) zahirahAverage / currentAssignments;
zahirahAverage = Math.Round(zahirahAverage, 1);
zahirahLetterGrade = getLetterGrade(zahirahAverage, letterGrades);
string zahirahAvgStr = zahirahAverage.ToString("0.0");

jeongAverage = (decimal) jeongAverage / currentAssignments;
jeongAverage = Math.Round(jeongAverage, 1);
jeongLetterGrade = getLetterGrade(jeongAverage, letterGrades);
string jeongAvgStr = jeongAverage.ToString("0.0");

Console.WriteLine("Student\t\tGrade\nSophia:\t\t{0:D}\t{1}\nNicolas:\t{2:D}\t{3}\nZahirah:\t{4:D}\t{5}\nJeong:\t\t{6:D}\t{7}",sophiaAvgStr,sophiaLetterGrade, nicolasAvgStr, nicolasLetterGrade, zahirahAvgStr, zahirahLetterGrade, jeongAvgStr, jeongLetterGrade);

static string getLetterGrade(decimal average, string[] letterGrades){
    if(average >= 90){
        return letterGrades[0];
    } else if (average >= 80){
        return letterGrades[1];
    } else if (average >= 70){
        return letterGrades[2];
    } else if (average >= 60){
        return letterGrades[3];
    } else {
        return letterGrades[4];
    };
};