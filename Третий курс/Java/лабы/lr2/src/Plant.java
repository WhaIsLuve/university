public class Plant {
    private String name;
    private String directorName;
    private int countWorkers;

    public Plant(String name, String directorName, int countWorkers) {
        this.name = name;
        this.directorName = directorName;
        this.countWorkers = countWorkers;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDirectorName() {
        return directorName;
    }

    public void setDirectorName(String directorName) {
        this.directorName = directorName;
    }

    public int getCountWorkers() {
        return countWorkers;
    }

    public void setCountWorkers(int countWorkers) {
        this.countWorkers = countWorkers;
    }
}
