import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './components/authen/login/login.component';
import { RegisterComponent } from './components/authen/register/register.component';
import { StockHomeComponent } from './components/stock/stock-home/stock-home.component';
import { StockCreateComponent } from './components/stock/stock-create/stock-create.component';
import { StockEditComponent } from './components/stock/stock-edit/stock-edit.component';
import { ShopHomeComponent } from './components/shop/shop-home/shop-home.component';

const routes: Routes = [
  {path : 'login', component : LoginComponent},
  {path : 'register', component : RegisterComponent},
  {path : 'stock', component : StockHomeComponent},
  {path : 'stock/create', component : StockCreateComponent},
  {path : 'stock/edit/:id', component : StockEditComponent},
  {path : 'shop', component : ShopHomeComponent},
  {path : '', redirectTo : 'login', pathMatch: 'full'},
  {path : '**', redirectTo : 'login'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
