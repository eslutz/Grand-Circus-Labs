import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
	title = 'Things To Do';
	
	toDoList: ToDo[] = [
		{task: "Default Item 1", completed: false},
		{task: "Default Item 2", completed: false},
		{task: "Default Item 3", completed: true}
	];

	addTask = function(newItem: string) {
		this.toDoList.push({task: newItem, completed: false});
	}

	completeTask = function(completeMe: ToDo) {
			completeMe.completed = true;
	}

	deleteTask = function(remove: ToDo) {
		this.toDoList.splice(this.toDoList.indexOf(remove), 1);
	}
}

interface ToDo {
	task: string;
	completed: boolean;
}