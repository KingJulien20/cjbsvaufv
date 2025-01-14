namespace Proiect_POO_NR2;
//nou

    public class User 
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private static List<User> users = new List<User>(); 
        private List<int> angajati = new List<int>();
       
        public IReadOnlyList<int> Angajati => angajati.AsReadOnly();
        public static IReadOnlyList<User> Users => users.AsReadOnly();

        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }
        
        public static void AddUser(User user)
        {
            if (!users.Any(u => u.Id == user.Id))
            {
                users.Add(user);
                Console.WriteLine($"User {user.Name} added successfully.");
            }
            else
            {
                Console.WriteLine($"User with ID {user.Id} already exists.");
            }
        }
        
        public static void GetUserById(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                Console.WriteLine($"User found: ID: {user.Id}, Name: {user.Name}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        
        public static void DisplayAllUsers()
        {
            Console.WriteLine("All Users:");
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}");
            }
        }
        
        public void AddAngajat(int id)
        {
            if (!angajati.Contains(id))
            {
                angajati.Add(id);
                Console.WriteLine($"Angajatul cu ID-ul {id} a fost adăugat.");
            }
            else
            {
                Console.WriteLine($"Angajatul cu ID-ul {id} este deja adăugat.");
            }
        }
    }
