function cats(input){
    class Cat{
        constructor(name, age){
            this.name = name,
            this.age = age
        }

        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`);
        }
    }

    let cats = [];
    input.forEach(catInfo => {
        const [name, age] = catInfo.split(' ');
        cats.push(new Cat(name, age));
    });

    for (const cat of cats) {
        cat.meow();
    }
}

cats(['Candy 1', 'Poppy 3', 'Nyx 2']);