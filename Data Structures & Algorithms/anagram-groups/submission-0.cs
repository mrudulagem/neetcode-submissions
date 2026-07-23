public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        foreach(string str in strs) {
            var lookup = new int[26];
            for(int i = 0; i < str.Length; i++) {
                lookup[str[i] - 'a']++;
            }
            var key = string.Join(",",lookup);

            if(!result.ContainsKey(key)){
                result[key] = new List<string>();
            }
            result[key].Add(str);
        }

        return result.Values.ToList<List<string>>();
    }
}
