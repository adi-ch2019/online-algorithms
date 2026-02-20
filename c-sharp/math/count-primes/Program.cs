        int n=10;
        if (n < 2) {
            System.Environment.Exit(0);
        }
        
        bool[] isPrime = new bool[n];
        for (int i = 2; i < n; i++) {
            isPrime[i] = true;
        }
        
        // Sieve of Eratosthenes
        for (int i = 2; i * i < n; i++) {
            if (isPrime[i]) {
                for (int j = i * i; j < n; j += i) {
                    isPrime[j] = false;
                }
            }
        }
        
        // Count primes
        int count = 0;
        for (int i = 2; i < n; i++) {
            if (isPrime[i]) 
            {
                count++;
                Console.WriteLine(i);
            }
        }
        //Console.WriteLine(count);