using System;
using NUnit.Framework;

namespace MathProblems
{
    class Program
    {
        /// <summary>
        /// Bereken de som van de Kleinste Gemene Veelvoud van een reeks beginnend bij 1 tot opgegeven parameter A
        /// </summary>
        /// <param name="a">het getal waarvan de reeks berekend moet worden</param>
        /// <returns>De som van de KGV van de reeks</returns>
        [TestCase(14, ExpectedResult = 910)]
        [TestCase(13, ExpectedResult = 1027)]
        [TestCase(12, ExpectedResult = 468)]
        [TestCase(11, ExpectedResult = 616)]
        [TestCase(10, ExpectedResult = 320)]
        [TestCase(9, ExpectedResult = 279)]
        [TestCase(8, ExpectedResult = 176)]
        [TestCase(7, ExpectedResult = 154)]
        [TestCase(6, ExpectedResult = 66)]
        [TestCase(5, ExpectedResult = 55)]
        [TestCase(4, ExpectedResult = 24)]
        [TestCase(3, ExpectedResult = 12)]
        [TestCase(2, ExpectedResult = 4)]
        static public int SomKGV(int a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Bereken het kleinste gemene (gemeenschappelijke) veelvoud van de parameters A en B
        /// waarbij geldt dat KGV = | a*b | / GGD(a,b)
        /// </summary>
        /// <param name="a">factor a</param>
        /// <param name="b">factor b</param>
        /// <returns></returns>
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(6, 3, ExpectedResult = 6)]
        [TestCase(3, 6, ExpectedResult = 6)]
        [TestCase(6, 4, ExpectedResult = 12)]
        [TestCase(4, 6, ExpectedResult = 12)]
        [TestCase(5, 6, ExpectedResult = 30)]
        [TestCase(15, 27, ExpectedResult = 15*27/3)]
        [TestCase(27, 15, ExpectedResult = 135)]
        static public int KleinsteGemeneVeelvoud(int a, int b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Bereken de Grootste Gemene (gemeenschappelijke) Deler van twee getallen (a en b)
        /// </summary>
        /// <param name="a">factor a</param>
        /// <param name="b">factor b</param>
        /// <returns></returns>
        [TestCase(15, 27, ExpectedResult = 3)]
        [TestCase(27, 15, ExpectedResult = 3)]
        [TestCase(6, 3, ExpectedResult = 3)]
        [TestCase(3, 6, ExpectedResult = 3)]
        [TestCase(6, 4, ExpectedResult = 2)]
        [TestCase(4, 6, ExpectedResult = 2)]
        [TestCase(5, 6, ExpectedResult = 1)]
        [TestCase(6, 5, ExpectedResult = 1)]
        static public int GrootsteGemenedeler(int a, int b)
        {
            throw new NotImplementedException();
        }
    }// class Program
}//MathProblems
