import math

from part_2.ex2.ui import prints


def main():
    prints.print_len()

    print()
    sum = 1000
    prints.pythagorean_triplet_by_sum(sum)

    print()
    prints.print_is_sorted()

    print()
    prints.calcs()

    print()
    prints.print_pi_digits()


if __name__ == '__main__':
    main()
