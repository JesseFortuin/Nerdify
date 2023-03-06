namespace Nerdify.BL
{
    public class CharacterReplacer : ICharacterReplacer
    {
        public string Nerdify(string str)
        {
            try
            {
                return str.Replace('a', '4').Replace('e', '3').Replace('l', '1').Replace('A', '4').Replace('E', '3');
            }
            catch
            {
                throw new ArgumentNullException(); 
            }
        }
    }
}