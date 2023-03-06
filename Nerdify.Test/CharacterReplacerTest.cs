using Nerdify.BL;

namespace Nerdify.Test
{
    public class CharacterReplacerTest
    {
        [Theory]
        [InlineData("Fund4m3nt41s", "Fund4m3nt41s")]
        [InlineData("Seven", "S3v3n")]
        [InlineData("Los Angeles", "Los 4ng313s")]
        [InlineData("Seoijselawuue", "S3oijs314wuu3")]

        public void NerdifyTest(string input, string expected)
        {
            //arrange
            ICharacterReplacer replacer = CharacterReplacer.Nerdify(input);

            //act
            string actual = replacer.Nerdify(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}