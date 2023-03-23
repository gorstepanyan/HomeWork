namespace Lesson38_Delegate
{
    internal class StringHelper
    {
        public int GetCount(string str)
        {
            return str.Length;
        }
        public int GetCountSymbolA(string str)
        {
            return str.Count(c => c == 'A');
        }
        public int GetCountSymbol(string str, char symbol)
        {
            return str.Count(c => c == symbol);
        }
    }
}
