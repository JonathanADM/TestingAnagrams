using NUnit.Framework;
using Anagrams;

namespace AnagramsTest
{
    public class ProbarAnagramsTest
    {
        [Test]
        public void AreAnagrams_s1_IsNull()
        {
            ProbarAnagrams probarAnagrams = new ProbarAnagrams();
            Assert.That(() => probarAnagrams.AreAnagrams(null, "hola"), Throws.ArgumentNullException);
        }

        [Test]
        public void AreAnagrams_s2_IsNull()
        {
            ProbarAnagrams probarAnagrams = new ProbarAnagrams();
            Assert.That(() => probarAnagrams.AreAnagrams("hola", null), Throws.ArgumentNullException);
        }

        [Test]
        public void AreAnagrams_s1_s2_NotIsNull()
        {
            ProbarAnagrams probarAnagrams = new ProbarAnagrams();
            Assert.That(() => probarAnagrams.AreAnagrams("hey", "hola"), Throws.Nothing);
        }

        [Test]
        public void AreAnagrams_IsTrue()
        {
            ProbarAnagrams probarAnagrams = new ProbarAnagrams();
            Assert.That(probarAnagrams.AreAnagrams("romo", "moro"), Is.True);
        }

        [Test]
        public void AreAnagrams_IsFalse()
        {
            ProbarAnagrams probarAnagrams = new ProbarAnagrams();
            Assert.That(probarAnagrams.AreAnagrams("hola", "moro"), Is.False);
        }
    }
}