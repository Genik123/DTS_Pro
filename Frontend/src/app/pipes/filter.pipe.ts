 import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(value: any[], filterString:string, clientName:string ): any[] {
      const resultArray =[];
      if(value.length === 0 || filterString === '' || clientName === ''){
        return value;
      }

       for(const item of value)
       {
           if(item[clientName].includes(filterString))
           resultArray.push(item)
       }
   return resultArray;
  }

}
