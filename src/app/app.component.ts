import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
	title = 'Things To Do';
	
	toDoList: ToDo[] = [
		{task: "Get a good nights sleep", completed: false},
		{task: "Walk the dogs", completed: true},
		{task: "Create a to do list program", completed: false},
		{task: "Pay bills", completed: false},
		{task: "Make dinner", completed: true},
		{task: "RELAX!!!", completed: false}
	];

	addTask(newItem: string) {
		this.toDoList.push({task: newItem, completed: false});
	}

	completeTask(completeMe: ToDo) {
			completeMe.completed = true;
	}

	removeTask(remove: ToDo) {
		this.toDoList.splice(this.toDoList.indexOf(remove), 1);
	}

	allTasksComplete(){
		if (this.toDoList.length == 0 || this.toDoList.filter(x => x.completed == true).length == this.toDoList.length) {
			return true;
		}
		else {
			return false;
		}
	}

	// filterTask(filter: string) {
	// 	return this.toDoList.filter(x => x.task.includes(filter));
	// }
}

interface ToDo {
	task: string;
	completed: boolean;
}