public class Solution {
    public int CharacterReplacement(string s, int k) {
        var frequencies = new Dictionary<char, int>();
        int l = 0, res = 0;

        for(int r = 0; r < s.Length; r++) {
            frequencies[s[r]] = 1 + frequencies.GetValueOrDefault(s[r], 0);

            while((r - l + 1) - frequencies.Values.Max() > k) {
                frequencies[s[l]]--;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
