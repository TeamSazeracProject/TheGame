using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.Data
{
    public class Images
    {
        #region Fileds
        private string[] humanWithSword = LoadFile(@"../../Data/Images/HumanWithSword.txt");
        private string[] humanWithStaff = LoadFile(@"../../Data/Images/HumanWithStaff.txt");
        private string[] humanOld = LoadFile(@"../../Data/Images/HumanOld.txt");
        private string[] humanWithTwoSabers = LoadFile(@"../../Data/Images/HumanWithTwoSabers.txt");
        private string[] humanWithShieldAndBigSword = LoadFile(@"../../Data/Images/HumanWithShieldAndBigSword.txt");
        private string[] humanInFlame = LoadFile(@"../../Data/Images/HumanInFlame.txt");
        private string[] damage = LoadFile(@"../../Data/Images/Damage.txt");
        private string[] dog = LoadFile(@"../../Data/Images/Dog.txt");
        private string[] gnome = LoadFile(@"../../Data/Images/Gnome.txt");
        private string[] bear = LoadFile(@"../../Data/Images/Bear.txt");
        private string[] demon = LoadFile(@"../../Data/Images/Demon.txt");
        private string[] wareWolf = LoadFile(@"../../Data/Images/WareWolf.txt");
        private string[] spider = LoadFile(@"../../Data/Images/Spider.txt");
        private string[] introText = LoadFile(@"../../Data/Images/IntroText.txt");
        #endregion

        #region Properties
        public string[] HumanWithSword { get { return this.humanWithSword; } }
        public string[] HumanWithStaff { get { return this.humanWithStaff; } }
        public string[] HumanOld { get { return this.humanOld; } }
        public string[] HumanWithTwoSabers { get { return this.humanWithTwoSabers; } }
        public string[] HumanWithShieldAndBigSword { get { return this.humanWithShieldAndBigSword; } }
        public string[] HumanInFlame { get { return this.humanInFlame; } }
        public string[] Damage { get { return this.damage; } }
        public string[] Dog { get { return this.dog; } }
        public string[] Gnome { get { return this.gnome; } }
        public string[] Bear { get { return this.bear; } }
        public string[] Demon { get { return this.demon; } }
        public string[] WareWolf { get { return this.wareWolf; } }
        public string[] Spider { get { return this.spider; } }
        public string[] IntroText { get { return this.introText; } }
        #endregion
        
        private static string[] LoadFile(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Valid filename must be provided!");

            List<string> fileData = new List<string>(50);
            string line;

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(fileName, Encoding.Unicode);
                while ((line = reader.ReadLine()) != null)
                {
                    fileData.Add(line);
                }
            }

            catch (System.IO.IOException ex)
            {
                throw new Exception("Error: Could not read file from disk. Original error: " + ex.Message);
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return fileData.ToArray();
        }

    }
}
