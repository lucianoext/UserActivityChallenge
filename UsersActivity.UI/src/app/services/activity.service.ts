import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Activity } from '../models/activity';

@Injectable({
  providedIn: 'root'
})
export class ActivityService {

  private url ="Activity"
  constructor(private http: HttpClient) { }

  public getActivities() : Observable<Activity[]> 
  {
    return this.http.get<Activity[]>(`${environment.apiUrl}/${this.url}`)
  }
}
