using System;
using System.Collections;
using System.IO;
using System.Text;
using static System.Console;

namespace Menutest
{
    internal class CGPA
    {
        public string Dept, sem;
        public ArrayList CSE1, CSE2, CSE3, CSE4, CSE5, CSE6, CSE7, CSE8, temp;
        public float[] CPCSE1, CPCSE2, CPCSE3, CPCSE4, CPCSE5, CPCSE6, CPCSE7, CPCSE8;


        public CGPA()
        {



            Subjects(out CSE1, out CSE2, out CSE3, out CSE4, out CSE5, out CSE6, out CSE7, out CSE8);
            Scores(out CPCSE1, out CPCSE2, out CPCSE3, out CPCSE4, out CPCSE5, out CPCSE6, out CPCSE7, out CPCSE8);

            ArrayList temp = new ArrayList();
            //getinput(out Dept, out sem);
            //temp = checkcondition(CSE1, CPCSE1, CSE2, CPCSE2, CSE3, CPCSE3, CSE4, CPCSE4, CSE5, CPCSE5, CSE6, CPCSE6, CSE7, CPCSE7, CSE8, CPCSE8, temp, Dept, sem);

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
            CPCSE8 = new float[] { 2f, 2f, 1f, 2f, 8f };
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
            WriteLine($"{Dept} {sem}");
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

        private static ArrayList CalculateGPA(ArrayList CSE4, float[] CPCSE, string Dept, string sem)
        {
            ArrayList temp;
            Console.WriteLine($"You belong to Department of {Dept}\nYou are in semester {sem}\n\n");
            temp = CSE4;
            string[] grade = new string[temp.Count];
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
                gpaNUM = CPCSE[i] * score[i] + gpaNUM;
                gpaDEN = CPCSE[i] + gpaDEN;
            }
            GPA = gpaNUM / gpaDEN;

            WriteLine("\n\nGPA is " + GPA + "\n\n");
            string ch = "N";
            WriteLine("Do you want to export your GPA results?\n(Y/N):");
            ch = ReadLine();
            ch = ch.Trim();
            if (ch.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/GPA.txt";
                       
                    if (File.Exists(path))
                    {
                        WriteLine("file already exists in " + path);
                        Write("Do you want to overwrite?:");
                        ch = ReadLine();

                        if (ch.Equals("Y", StringComparison.OrdinalIgnoreCase))
                        {
                            writeandreadtofile(Dept, sem, temp, CPCSE, grade, score, GPA, path);
                        }
                        else if (ch.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            WriteLine("Enter a new name to create a new file");
                            Write("New name:");
                            string newname = ReadLine();
                            path = Path.GetDirectoryName(path);
                            path = path + "" + newname + ".txt";
                            WriteLine(path);
                            writeandreadtofile(Dept, sem, temp, CPCSE, grade, score, GPA, path);



                        }

                    }
                    else
                    {
                        writeandreadtofile(Dept, sem, temp, CPCSE, grade, score, GPA, path);
                    }


                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
            else
            {

            }

            return null;
        }

        private static void writeandreadtofile(string Dept, string sem, ArrayList temp, float[] CPCSE, string[] grade, int[] score, float GPA, string path)
        {
            using (FileStream fs = File.Create(path))
            {
                // Add some text to file    
                byte[] title = new UTF8Encoding(true).GetBytes("Department of " + Dept + "\n");
                fs.Write(title, 0, title.Length);
                byte[] author = new UTF8Encoding(true).GetBytes($"Your Semester {sem} GPA is {GPA} \n\n");
                fs.Write(author, 0, author.Length);
                for (int i = 0; i < temp.Count; i++)
                {
                    byte[] line = new UTF8Encoding(true).GetBytes($"{temp[i]}\nGrade Recieved: {grade[i].ToUpper()} Grade Point: {score[i]} Subject Credit: {CPCSE[i]} \n\n");
                    fs.Write(line, 0, line.Length);
                }
            }

            // Open the stream and read it back.    
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                WriteLine($"Exported successfully!\n path:{path}");

            }
        }

        public void selected()
        {
            temp = checkcondition(CSE1, CPCSE1, CSE2, CPCSE2, CSE3, CPCSE3, CSE4, CPCSE4, CSE5, CPCSE5, CSE6, CPCSE6, CSE7, CPCSE7, CSE8, CPCSE8, temp, Dept, sem);
        }


        private static void Getgrade(ArrayList temp, string[] grade, int[] score)
        {
            char[] gradetemp = new char[temp.Count];

            for (int i = 0; i < temp.Count; i++)
            {
                //To try again if execption instead of ending execution
                bool retry = true;
                while (retry)
                {
                    Write(temp[i] + ": ");
                    try
                    {
                        gradetemp[i] = Convert.ToChar(ReadLine());
                        grade[i] = Convert.ToString(gradetemp[i]);
                        if (!grade[i].Equals("S", StringComparison.OrdinalIgnoreCase) && !grade[i].Equals("A", StringComparison.OrdinalIgnoreCase) && !grade[i].Equals("B", StringComparison.OrdinalIgnoreCase) && !grade[i].Equals("C", StringComparison.OrdinalIgnoreCase) && !grade[i].Equals("D", StringComparison.OrdinalIgnoreCase) && !grade[i].Equals("E", StringComparison.OrdinalIgnoreCase) && !grade[i].Equals("F", StringComparison.OrdinalIgnoreCase))
                        {
                           throw (null);
                        }
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

        private static void GradetoGP(string[] grade, int[] score, int i)
        {
           
            if (grade[i].Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                score[i] = 10;
            }
            else if (grade[i].Equals("A", StringComparison.OrdinalIgnoreCase))
            {
                score[i] = 9;
            }
            else if (grade[i].Equals("B", StringComparison.OrdinalIgnoreCase))
            {
                score[i] = 8;
            }
            else if (grade[i].Equals("C", StringComparison.OrdinalIgnoreCase))
            {
                score[i] = 7;
            }
            else if (grade[i].Equals("D", StringComparison.OrdinalIgnoreCase))
            {
                score[i] = 6;
            }
            else if (grade[i].Equals("E", StringComparison.OrdinalIgnoreCase))
            {
                score[i] = 5;
            }
            else if (grade[i].Equals("F", StringComparison.OrdinalIgnoreCase))
            {
                score[i] = 0;
            }
            else
                score[i] = 0;

        }
    }
}

