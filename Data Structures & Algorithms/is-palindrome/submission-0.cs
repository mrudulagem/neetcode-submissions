public class Solution {
    public bool IsPalindrome(string s) {
        int forward = 0, back = s.Length - 1;
        while(forward < back) {
            while(forward < back && !IsAlphaNumeric(s[forward])) {
                forward++;
            }

            while(forward < back && !IsAlphaNumeric(s[back])) {
                back--;
            }

            if(char.ToLower(s[forward]) != char.ToLower(s[back])) {
                return false;
            }
            forward++;
            back--;
        }
        return true;
    }

    private bool IsAlphaNumeric(char c) {
        return ((c >= 'A' && c <= 'Z') ||
                (c >= 'a' && c <= 'z') ||
                (c >= '0' && c <= '9')
        );
    }
}
