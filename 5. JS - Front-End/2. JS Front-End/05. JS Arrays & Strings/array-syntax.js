const array = [];

array.length = 2;

array.push('asd');
array.push('asd');
array.push('asd');

array.length = 3;

console.log(array);

array[-1] = 'test';
array[-2] = 'test2'

console.log(array);