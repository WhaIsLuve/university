import java.util.Vector;
import java.util.Iterator;
import java.util.TreeSet;
import java.util.Collections;
import java.util.Comparator;

public class Main {
    static class Workshop {
        private String name;
        private String chief;
        private int workersCount;

        public Workshop(String name, String chief, int workersCount) {
            this.name = name;
            this.chief = chief;
            this.workersCount = workersCount;
        }

        @Override
        public String toString() {
            return name + " (Начальник: " + chief + ", Работников: " + workersCount + ")";
        }

        public String getName() { return name; }
        public String getChief() { return chief; }
        public int getWorkersCount() { return workersCount; }
        public void setName(String name) { this.name = name; }
        public void setChief(String chief) { this.chief = chief; }
        public void setWorkersCount(int workersCount) { this.workersCount = workersCount; }
    }

    public static void main(String[] args) {
        System.out.println("=== Программа 1: Работа с встроенным типом char ===");
        program1();

        System.out.println("\n=== Программа 2: Работа с пользовательским типом Workshop ===");
        program2();

        System.out.println("\n=== Программа 3: Алгоритмы работы с коллекциями ===");
        program3();
    }

    // Программа 1: Демонстрация работы с встроенным типом char
    private static void program1() {
        // 1. Создать и заполнить Vector<Character>
        Vector<Character> vector1 = createCharVector('A', 'J');

        // 2. Просмотреть контейнер
        System.out.println("\n1. Исходный Vector:");
        printVector(vector1);

        // 3. Изменить контейнер
        modifyCharVector(vector1);

        // 4. Просмотреть с помощью итератора
        System.out.println("\n4. Измененный Vector (через итератор):");
        printVectorWithIterator(vector1);

        // 5. Создать второй Vector
        Vector<Character> vector2 = createCharVector('K', 'O');

        // 6. Изменить первый Vector
        modifyAndMergeVectors(vector1, vector2, 4, 2);

        // 7. Просмотреть оба контейнера
        System.out.println("\n7. Первый Vector после изменений:");
        printVector(vector1);
        System.out.println("Второй Vector:");
        printVector(vector2);
    }

    private static Vector<Character> createCharVector(char start, char end) {
        Vector<Character> vector = new Vector<>();
        for (char c = start; c <= end; c++) {
            vector.add(c);
        }
        return vector;
    }

    private static <T> void printVector(Vector<T> vector) {
        System.out.println(vector);
    }

    private static <T> void printVectorWithIterator(Vector<T> vector) {
        Iterator<?> it = vector.iterator();
        while (it.hasNext()) {
            System.out.print(it.next() + " ");
        }
        System.out.println();
    }

    private static void modifyCharVector(Vector<Character> vector) {
        vector.remove(3);
        vector.set(5, 'X');
    }

    private static void modifyAndMergeVectors(Vector<Character> vector1, Vector<Character> vector2, int startIndex, int n) {
        for (int i = 0; i < n && startIndex < vector1.size(); i++) {
            vector1.remove(startIndex);
        }
        vector1.addAll(vector2);
    }

    private static void program2() {
        Vector<Workshop> workshops = createWorkshops();
        System.out.println("\n1. Исходный список цехов:");
        printVector(workshops);
        modifyWorkshops(workshops);
        System.out.println("\n2. Измененный список цехов (через итератор):");
        printVectorWithIterator(workshops);
        Vector<Workshop> workshops2 = createAdditionalWorkshops();
        modifyAndMergeWorkshops(workshops, workshops2, 1, 1);
        System.out.println("\n7. Первый список цехов после изменений:");
        printVector(workshops);
        System.out.println("Второй список цехов:");
        printVector(workshops2);
    }

    private static Vector<Workshop> createWorkshops() {
        Vector<Workshop> workshops = new Vector<>();
        workshops.add(new Workshop("Цех №1", "Иванов", 15));
        workshops.add(new Workshop("Цех №2", "Петров", 20));
        workshops.add(new Workshop("Цех №3", "Сидоров", 10));
        workshops.add(new Workshop("Цех №4", "Кузнецов", 25));
        workshops.add(new Workshop("Цех №5", "Васильев", 18));
        return workshops;
    }

    private static void modifyWorkshops(Vector<Workshop> workshops) {
        workshops.remove(2);
        workshops.get(1).setChief("Смирнов");
    }

    private static Vector<Workshop> createAdditionalWorkshops() {
        Vector<Workshop> workshops = new Vector<>();
        workshops.add(new Workshop("Цех №6", "Федоров", 30));
        workshops.add(new Workshop("Цех №7", "Николаев", 22));
        return workshops;
    }

    private static void modifyAndMergeWorkshops(Vector<Workshop> workshops1, Vector<Workshop> workshops2, int startIndex, int n) {
        for (int i = 0; i < n && startIndex < workshops1.size(); i++) {
            workshops1.remove(startIndex);
        }
        workshops1.addAll(workshops2);
    }

    private static void program3() {
        Vector<Workshop> workshops = createWorkshopsForAlgorithms();
        sortWorkshopsAscending(workshops);
        System.out.println("\n1. Отсортированный по возрастанию Vector:");
        printVector(workshops);
        Workshop found = findWorkshop(workshops);
        System.out.println("\n2. Найденный цех (работников > 15): " + found);
        TreeSet<Workshop> workshopSet = moveToTreeSet(workshops);
        System.out.println("\n3. TreeSet (цехи с работниками > 15):");
        printWorkshopSet(workshopSet);
        sortWorkshopsDescending(workshops);
        System.out.println("\n4. Vector после удаления (по убыванию):");
        printVector(workshops);
        System.out.println("\n5. TreeSet (по убыванию):");
        printWorkshopSet(workshopSet);
        Vector<Workshop> mergedWorkshops = mergeContainers(workshops, workshopSet);
        System.out.println("\n6. Объединенный Vector:");
        printVector(mergedWorkshops);
    }

    private static Vector<Workshop> createWorkshopsForAlgorithms() {
        Vector<Workshop> workshops = new Vector<>();
        workshops.add(new Workshop("Цех №3", "Сидоров", 10));
        workshops.add(new Workshop("Цех №1", "Иванов", 15));
        workshops.add(new Workshop("Цех №5", "Васильев", 18));
        workshops.add(new Workshop("Цех №2", "Петров", 20));
        workshops.add(new Workshop("Цех №4", "Кузнецов", 25));
        return workshops;
    }

    private static void sortWorkshopsAscending(Vector<Workshop> workshops) {
        workshops.sort(Comparator.comparingInt(Workshop::getWorkersCount));
    }

    private static Workshop findWorkshop(Vector<Workshop> workshops) {
        return workshops.stream()
                .filter(w -> w.getWorkersCount() > 15)
                .findFirst()
                .orElse(null);
    }

    private static TreeSet<Workshop> moveToTreeSet(Vector<Workshop> workshops) {
        TreeSet<Workshop> workshopSet = new TreeSet<>(
                Comparator.comparingInt(Workshop::getWorkersCount).reversed());

        workshops.removeIf(w -> {
            if (w.getWorkersCount() > 15) {
                workshopSet.add(w);
                return true;
            }
            return false;
        });

        return workshopSet;
    }

    private static void printWorkshopSet(TreeSet<Workshop> workshopSet) {
        workshopSet.forEach(System.out::println);
    }

    private static void sortWorkshopsDescending(Vector<Workshop> workshops) {
        workshops.sort(Comparator.comparingInt(Workshop::getWorkersCount).reversed());
    }

    private static Vector<Workshop> mergeContainers(Vector<Workshop> workshops, TreeSet<Workshop> workshopSet) {
        Vector<Workshop> merged = new Vector<>();
        merged.addAll(workshops);
        merged.addAll(workshopSet);
        return merged;
    }
}