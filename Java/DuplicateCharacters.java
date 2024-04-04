import java.util.HashMap;

public class DuplicateCharacters {
    public static void main(String[] args) {
        String str = "Hello World";


        str = str.replaceAll("\\s+", "").toLowerCase();

        HashMap<Character, Integer> charFrequencyMap = new HashMap<>();

        for (char c : str.toCharArray()) {
            if (charFrequencyMap.containsKey(c)) {

                charFrequencyMap.put(c, charFrequencyMap.get(c) + 1);
            } else {

                charFrequencyMap.put(c, 1);
            }
        }

        System.out.println("Duplicate characters:");
        for (char c : charFrequencyMap.keySet()) {
            if (charFrequencyMap.get(c) > 1) {
                System.out.println(c);
            }
        }
    }
}
