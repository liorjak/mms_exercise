def is_sorted_palindrome(word_to_check: str) -> bool:
    if word_to_check == reversed(word_to_check):
        for i in range((len(word_to_check) // 2) - 1):
            if word_to_check[i] > word_to_check[i + 1]:
                return False
        return True
    return False
