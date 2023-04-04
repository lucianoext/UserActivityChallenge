import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { filter } from 'rxjs';
import { User } from 'src/app/models/user';
import { UserService } from 'src/app/services/user.service';


@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent {
  users: User[] = [];
  userToEdit?: User;
  constructor(private userService: UserService) {}

  ngOnInit() : void {
    this.userService.getUsers().subscribe((result: User[])=>(this.users = result.filter((obj) => obj.activo == true
    )))
  }

  updateUserList(users: User[]){
    this.users = users.filter((obj) => {
      return obj.activo == true;
    });
  }
  initNewUser(){
    this.userToEdit = new User();
  }

  editUser(user: User){
    this.userToEdit = user;
  }
}
