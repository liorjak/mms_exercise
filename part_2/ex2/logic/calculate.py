def sorted_numbers(numbers: list) -> list:
    return sorted(numbers)


def count_of_positive_numbers(numbers: list) -> int:
    count_of_positive = 0
    for i in range(len(numbers)):
        if numbers[i] > 0:
            count_of_positive += 1
    return count_of_positive


def calculate_average(numbers: list) -> float:
    sum_of_numbers = 0
    for i in range(len(numbers)):
        sum_of_numbers += numbers[i]
    return sum_of_numbers / len(numbers)
