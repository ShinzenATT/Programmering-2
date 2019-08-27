package repition_prog1;

public class Person {
	String name = "";
	int age = 0;
	
	public Person(String naming, int aging){
		name = naming;
		age = aging;
		
	}
	
	public int age() {
		return age;
	}
	
	public String name() {
		return name;
	}
	
	public void oldest(Person a, Person b) {
		if(a.age() > b.age()) {
			System.out.println(a.name() + " is the oldest.");
		}
		else if(a.age() < b.age()) {
			System.out.println(b.name() + " is the oldest.");
		}
		else {
			System.out.println("They are the same age.");
		}
		return;
	}
	
	public void oldest(Person b) {
		oldest(new Person(name, age), b);
		return;
	}
	
}
