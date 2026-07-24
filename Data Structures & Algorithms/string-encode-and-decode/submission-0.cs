public class Solution {

    public string Encode(IList<string> strs) {
        var builder = new StringBuilder();
        foreach(string str in strs) {
            builder.Append(str.Length).Append("#").Append(str);
        }
        return builder.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;
        while(i < s.Length) {
            int j = i;
            while(s[j] != '#') {
                j++;
            }
            // get the length of the word
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1; // start of the word
            j = i + length; // index after the end of the word
            result.Add(s.Substring(i, length));
            i = j;
        }

        return result;
   }
}
