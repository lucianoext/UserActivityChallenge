import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Activity } from 'src/app/models/activity';
import { ActivityService } from 'src/app/services/activity.service';

@Component({
  selector: 'app-edit-activity',
  templateUrl: './edit-activity.component.html',
  styleUrls: ['./edit-activity.component.css']
})
export class EditActivityComponent {
  @Input() activity?: Activity;
  @Output() activitysUpdated = new EventEmitter<Activity[]>();
  activities: Activity[] = [];

  constructor(private activityService: ActivityService) {}

  ngOnInit(): void {
    this.activityService.getActivities().subscribe((result: Activity[])=>(this.activities = result))
  }

  updateActivity(activity:Activity){
    this.activityService
    .updateActivity(activity)
    .subscribe((activities : Activity[]) => this.activitysUpdated.emit(activities));
  }
  deleteActivity(activity:Activity){
    this.activityService
    .deleteActivity(activity)
    .subscribe((activities : Activity[]) => this.activitysUpdated.emit(activities));
  }
  createActivity(activity:Activity){
    this.activityService
    .createActivity(activity)
    .subscribe((activities : Activity[]) => this.activitysUpdated.emit(activities));
  }
}
