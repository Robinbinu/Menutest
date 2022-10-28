using System;
using System.Collections;
using System.Runtime.CompilerServices;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace Menutest
{
    internal class CGPA
    {
        public CGPA()
        {
            ArrayList CSE1, CSE2, CSE3, CSE4, CSE5, CSE6, CSE7, CSE8;
            float[] CPCSE1, CPCSE2, CPCSE3, CPCSE4, CPCSE5, CPCSE6, CPCSE7, CPCSE8;


            Subjects(out CSE1, out CSE2, out CSE3, out CSE4, out CSE5, out CSE6, out CSE7, out CSE8);
            Scores(out CPCSE1, out CPCSE2, out CPCSE3, out CPCSE4, out CPCSE5, out CPCSE6, out CPCSE7, out CPCSE8);

            ArrayList temp = new ArrayList();
            string Dept, sem;
            getinput(out Dept, out sem);
            temp = checkcondition(CSE1, CPCSE1, CSE2, CPCSE2, CSE3, CPCSE3, CSE4, CPCSE4, CSE5, CPCSE5, CSE6, CPCSE6, CSE7, CPCSE7, CSE8, CPCSE8, temp, Dept, sem);

        }

        private static void Scores(out float[] CPCSE1, out float[] CPCSE2, out float[] CPCSE3, out float[] CPCSE4, out float[] CPCSE5, out float[] CPCSE6, out float[] CPCSE7, out float[] CPCSE8)
        {
            CPCSE1 = new float[] { 4.0f, 4.0f, 4.0f, 3.0f, 3.0f, 1.5f, 1.5f, 1.5f };
            CPCSE2 = new float[] { 4.0f, 4f, 3.0f, 3f, 0f, 1.5f, 1.5f };
            CPCSE3 = new float[] { 2f, 3f, 4f, 3f, 3f, 1.5f, 1.5f, 1.5f, 0 };
            CPCSE4 = new float[] { 4f, 3f, 3f, 3f, 4f, 1.5f, 1.5f, 1.5f };
            CPCSE5 = new float[] { 3f, 3f, 3f, 4f, 3f, 1.5f, 1.5f, 0f };
            CPCSE6 = new float[] { 2f, 3f, 3f, 4f, 3f, 3f, 1.5f, 1.5f };
            CPCSE7 = new float[] { 3f, 4f, 4f, 3f, 3f, 1.5f, 1f, 0f };
            CPCSE8 = new float[] { 2f, 2f, 1f, 2f, 8f};
        }

        private static void Subjects(out ArrayList CSE1, out ArrayList CSE2, out ArrayList CSE3, out ArrayList CSE4, out ArrayList CSE5, out ArrayList CSE6, out ArrayList CSE7, out ArrayList CSE8)
        {
            CSE1 = new ArrayList { "MA201 Mathematics I", "PH201 Physics", "CY201 Chemistry", "HS201 English for Communication", "ME201 Workshop and Manufacturing Practice", "PH202 Physics Laboratory", "CY202 Chemistry Laboratory" };
            CSE2 = new ArrayList { "MA202 Mathematics II", "EE201 Basic Electrical Engineering", "CS201 Programming for Problem Solving", "ME202 Engineering Graphics and Computer Aided Drawing", "CE201 Environmental Science", "EE202 Basic Electrical Engineering Laboratory", "CS202 Programming Laboratory" };
            CSE3 = new ArrayList { "SH201 Biology for Engineers", "EC235 Electronic Devices and Digital Systems", "CS203 Computer Organization and Architecture", "CS204 Data Structures", "CS205 Object Oriented Programming Languages", "EC236 Electronic Devices and Digital Systems Laboratory", "CS206 Data Structures Laboratory", "CS207 Object Oriented Programming Languages Laboratory", "SH202 Indian Constitution" };
            CSE4 = new ArrayList { "MA206 Mathematics for Computing", "CS208 Operating Systems", "CS209 Design and Analysis of Algorithms", "CS210 Database Management Systems", "CS211 Software Engineering", "CS212 Operating System Laboratory", "CS213 Design and Analysis of Algorithms Laboratory", "CS214 Database Management Systems Laboratory" };
            CSE5 = new ArrayList { "HS202 Industrial Economics and Management", "CS215 Platform Technologies", "CS216 Computer Networks", "CS217 Automata Theory and Compiler Design", "CSYXX Professional Elective Course - I", "CS218 Platform Technologies Laboratory", "CS219 Computer Networks Laboratory", "SH203 Essence of Indian Traditional Knowledge" };
            CSE6 = new ArrayList { "P201 Entrepreneurship", "CS220 Microprocessors and Microcontrollers", "CS221 Web Technologies", "CS222 Information Security", "CSYXX Professional Elective Course – II", "CSYXX Professional Elective Course – III", "CS223 Microprocessors and Microcontrollers Laboratory", " CS224 Web Technologies Laboratory" };
            CSE7 = new ArrayList { "CS225 Artificial Intelligence", "CS226 Parallel and Distributed", "CS227 Data Science Essentials", "CSYXX Professional Elective Co", "CSYXX Professional Elective Co", "CS228 Artificial Intelligence Lab", "CS229 Seminar", "CS230 Professional Ethics" };
            CSE8 = new ArrayList { "SWOXX Open Elective through SWAYAM ","WOXX Open Elective through SWAYAM","CS231 Comprehensive Test","CS232 Internship","CS233 Project Work PAC PR "
};
        }

        private static ArrayList checkcondition(ArrayList CSE1, float[] CPCSE1, ArrayList CSE2, float[] CPCSE2, ArrayList CSE3, float[] CPCSE3, ArrayList CSE4, float[] CPCSE4, ArrayList CSE5, float[] CPCSE5, ArrayList CSE6, float[] CPCSE6, ArrayList CSE7, float[] CPCSE7, ArrayList CSE8, float[] CPCSE8, ArrayList temp, string Dept, string sem)
        {
            switch (sem)
            {
                case "1" when Dept == "CSE":
                    temp = CalculateGPA(CSE1, CPCSE1, Dept, sem); break;
                case "2" when Dept == "CSE":
                    temp = CalculateGPA(CSE2, CPCSE2, Dept, sem); break;
                case "3" when Dept == "CSE":
                    temp = CalculateGPA(CSE3, CPCSE3, Dept, sem); break;
                case "4" when Dept == "CSE":
                    temp = CalculateGPA(CSE4, CPCSE4, Dept, sem); break;
                case "5" when Dept == "CSE":
                    temp = CalculateGPA(CSE5, CPCSE5, Dept, sem); break;
                case "6" when Dept == "CSE":
                    temp = CalculateGPA(CSE6, CPCSE6, Dept, sem); break;
                case "7" when Dept == "CSE":
                    temp = CalculateGPA(CSE7, CPCSE7, Dept, sem); break;
                case "8" when Dept == "CSE":
                    temp = CalculateGPA(CSE8, CPCSE8, Dept, sem); break;
                default:
                    WriteLine("Check input"); break;
            }

            return temp;
        }

        private static ArrayList CalculateGPA(ArrayList CSE4, float[] CPCSE4, string Dept, string sem)
        {
            ArrayList temp;
            Console.WriteLine($"You belong to Department of {Dept}\nYou are in semester {sem}\n\n");
            temp = CSE4;
            Char[] grade = new Char[temp.Count];
            int[] score = new int[temp.Count];
            Getgrade(temp, grade, score);
            WriteLine();
            Printscore(temp, score);
            //Calculate GPA
            //var begin
            float gpaNUM = 0;
            float gpaDEN = 0;
            float GPA = 0;
            //var end
            for (int i = 0; i < temp.Count; i++)
            {
                gpaNUM = CPCSE4[i] * score[i] + gpaNUM;
                gpaDEN = CPCSE4[i] + gpaDEN;
            }
            GPA = gpaNUM / gpaDEN;

            WriteLine("\n\n\n\nGPA is " + GPA);
            return temp;
        }

        private static void getinput(out string Dept, out string sem)
        {
            string[] Depts = { "CSE", "ECE", "EIE", "CHE", "MEC" };
            string prompt = "Enter your Department:";
            Menu menu = new Menu(prompt,Depts, 0, 0);
           menu.DisplayOps();
            WriteLine("Enter your Dept:");
            Dept = ReadLine();
            WriteLine("Enter your Semester:");
            sem = ReadLine();
        }

        private static void Getgrade(ArrayList temp, char[] grade, int[] score)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                //To try again if execption instead of ending execution
                bool retry = true;
                while (retry)
                {
                    Write(temp[i] + ": ");
                    try
                    {
                        grade[i] = Convert.ToChar(ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        WriteLine("Enter a valid grade!");
                        retry = true;

                    }
                }

                GradetoGP(grade, score, i);

            }
        }

        private static void Printscore(ArrayList temp, int[] score)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                WriteLine(temp[i] + ": " + score[i]);
            }
        }

        private static void GradetoGP(char[] grade, int[] score, int i)
        {
            switch (grade[i])
            {
                case 'S':
                    score[i] = 10;
                    break;
                case 'A':
                    score[i] = 9;
                    break;
                case 'B':
                    score[i] = 8;
                    break;
                case 'C':
                    score[i] = 7;
                    break;
                case 'D':
                    score[i] = 6;
                    break;
                case 'E':
                    score[i] = 5;
                    break;
                case 'F':
                    score[i] = 0;
                    break;
                default:
                    score[i] = 0;
                    break;
            }
        }
    }
}

