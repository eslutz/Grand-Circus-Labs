import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
	title = 'Things To Do';
	
	toDoList: ToDo[] = [
		{theItem: "Default Item 1", done: false},
		{theItem: "Default Item 2", done: false},
		{theItem: "Default Item 3", done: true}
	];

	addItem = function(newItem: string) {
		this.toDoList.push({theItem: newItem, done: false});
	}

	completeItem = function(completed: ToDo) {
			completed.done = true;
	}

	deleteItem = function(remove: ToDo) {
		this.toDoList.splice(this.toDoList.indexOf(remove), 1);
	}
}

interface ToDo {
	theItem: string;
	done: boolean;
}