int n = 10;
bool[] isPrime = new bool[n];
for (int i = 2; i < n; i++) isPrime[i] = true;

// Sieve
for (int i = 2; i * i < n; i++) {
    if (isPrime[i]) {
        for (int j = i * i; j < n; j += i) {
            isPrime[j] = false;
        }
    }
}

// First pass: count primes
int count = 0;
for (int i = 2; i < n; i++) {
    if (isPrime[i]) count++;
}

// Allocate array
int[] primesArray = new int[count];

// Second pass: fill array
int index = 0;
for (int i = 2; i < n; i++) {
    if (isPrime[i]) {
        primesArray[index++] = i;
    }
}

// Print array
Console.WriteLine("Prime numbers array:");
foreach (int prime in primesArray) {
    Console.Write(prime + " ");
}
