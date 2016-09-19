function solve() {
    'use strict';

    const ERROR_MESSAGES = {
        INVALID_NAME_TYPE: 'Name must be string!',
        INVALID_NAME_LENGTH: 'Name must be between between 2 and 20 symbols long!',
        INVALID_NAME_SYMBOLS: 'Name can contain only latin symbols and whitespaces!',
        INVALID_MANA: 'Mana must be a positive integer number!',
        INVALID_EFFECT: 'Effect must be a function with 1 parameter!',
        INVALID_DAMAGE: 'Damage must be a positive number that is at most 100!',
        INVALID_HEALTH: 'Health must be a positive number that is at most 200!',
        INVALID_SPEED: 'Speed must be a positive number that is at most 100!',
        INVALID_COUNT: 'Count must be a positive integer number!',
        INVALID_SPELL_OBJECT: 'Passed objects must be Spell-like objects!',
        NOT_ENOUGH_MANA: 'Not enough mana!',
        TARGET_NOT_FOUND: 'Target not found!',
        INVALID_BATTLE_PARTICIPANT: 'Battle participants must be ArmyUnit-like!'
    };

    class Spell {
        constructor(name, manaCost, effect) {
            this.name = name;
            this.manaCost = manaCost;
            this.effect = effect;
        }

        get name() {
            return this._name;
        }
        set name(value) {
            if (typeof value !== 'string') {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (value.length < 2 || value.length > 20) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_LENGTH);
            }
            // for (var index = 0; index < value.length; index++) {
            //     if ((value[index] < 'a' || value[index] > 'z') && (value[index] < 'a' || value[index] > 'z')) {
            //         throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            //     }
            // }
            // if (!(value.match('[a-zA-Z]+'))) {
            //     throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            // }
            var onlyLetters = /^[a-zA-Z ]*$/.test(value);
            if (!onlyLetters) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            }
            this._name = value;
        }
        get manaCost() {
            return this._manaCost;
        }
        set manaCost(value) {
            if (typeof value !== 'number') {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (value < 0) {
                throw new Error(ERROR_MESSAGES.INVALID_MANA);
            }
            this._manaCost = value;
        }
        get effect() {
            return this._effect;
        }
        set effect(value) {
            if (typeof value != "function") {
                throw new Error(ERROR_MESSAGES.INVALID_EFFECT);
            }

            this._effect = value
        }


    }

    class Unit {
        constructor(name, alignment) {
            this.name = name;
            this.alignment = alignment;
        }

        get name() {
            return this._name
        }
        set name(value) {
            if (typeof value !== 'string') {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (value.length < 2 || value.length > 20) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_LENGTH);
            }
            var onlyLetters = /^[a-zA-Z ]*$/.test(value);
            if (!onlyLetters) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            }
            this._name = value;
        }

        get alignment() {
            return this._alignment;
        }
        set alignment(value) {
            if (typeof value !== 'string') {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (value != 'good' && value != 'neutral' && value != 'evil') {
                throw new Error("Alignment must be good, neutral or evil!");
            }
            this._alignment = value;
        }
    }
    var armyUnitId = 0;
    class ArmyUnit extends Unit {
        constructor(name, alignment, damage, health, count, speed) {
            super(name, alignment);
            this._id = (armyUnitId += 1);
            this.damage = damage;
            this.health = health;
            this.count = count;
            this.speed = speed;
        }

        get id() {
            return this._id;
        }
        get damage() {
            return this._damage;
        }
        set damage(value) {
            this._damage = value;
        }
        get health() {
            return this._health;
        }
        set health(value) {
            this._health = value;
        }
        get count() {
            return this._count;
        }
        set count(value) {
            this._count = value;
        }
        get speed() {
            return this._speed;
        }
        set speed(value) {
            this._speed = value;
        }
    }

    class Commander extends Unit {
        constructor(name, alignment, mana) {
            super(name, alignment);
            this.mana = mana;
            this.spellbook = [];
            this.army = [];
        }

        get mana() {
            return this._mana;
        }
        set mana(value) {
            if (typeof value !== 'number') {
                throw new Error(ERROR_MESSAGES.INVALID_MANA);
            }
            if (value <= 0 || isNaN(value)) {
                throw new Error(ERROR_MESSAGES.INVALID_MANA);
            }
            this._mana = value;
        }
    }

    const battlemanager = {
        allCommanders: [],
        allArmyUnits: [],
        getCommander: function(name, alignment, mana) {
            return new Commander(name, alignment, mana);

        },
        getArmyUnit: function(options) {
            let name, alignment, damage, health, count, speed, isName = false,
                isAlignment = false,
                isDamage = false,
                isHealth = false,
                isCount = false,
                isSpeed = false;
            if (options.name != undefined) {
                name = options.name;
                isName = true;
            }
            if (options.alignment != undefined) {
                alignment = options.alignment;
                isAlignment = true;
            }
            if (options.damage != undefined) {
                damage = options.damage;
                isDamage = true
            }
            if (options.health != undefined) {
                health = options.health;
                isHealth = true;
            }
            if (options.count != undefined) {
                count = options.count;
                isCount = true;
            }
            if (options.speed != undefined) {
                speed = options.speed;
                isSpeed = true;
            }
            var newArmyUnit = new ArmyUnit(name, alignment, damage, health, count, speed);
            battlemanager.allArmyUnits.push(newArmyUnit);
            return new ArmyUnit(name, alignment, damage, health, count, speed);
        },
        getSpell: function(name, manaCost, effect) {
            return new Spell(name, manaCost, effect);
        },
        addCommanders: function(...args) {
            if (Array.isArray(args[0])) {
                args = args[0];
            }
            for (var index = 0; index < args.length; index++) {
                if (args[index] instanceof Commander) {
                    battlemanager.allCommanders.push(args[index]);
                }
            }

            return this;

        },
        addArmyUnitTo: function(commanderName, armyUnit) {
            for (var index = 0; index < battlemanager.allCommanders.length; index++) {
                if (battlemanager.allCommanders[index].name == commanderName) {
                    battlemanager.allCommanders[index].army.push(armyUnit);
                }
            }
            return this;
        },
        addSpellsTo: function(commanderName, ...spells) {
            for (var index = 0; index < battlemanager.allCommanders.length; index++) {
                if (commanderName === battlemanager.allCommanders[index].name) {
                    battlemanager.allCommanders[index].spellbook.push(...spells);
                }
            }
            return this;
        },
        findCommanders: function(query) {
            return battlemanager.allCommanders.filter(function(item) {
                return Object.keys(query).every(function(prop) {
                    return query[prop] === item[prop];
                });
            });
        },
        findArmyUnitById: function(id) {
            for (var index = 0; index < battlemanager.allArmyUnits.length; index++) {
                if (id = battlemanager.allArmyUnits[index].id) {
                    return battlemanager.allArmyUnits[index];
                }
            }
            return undefined;
        },
        findArmyUnits: function(query) {
            var result = battlemanager.allArmyUnits.filter(function(item) {
                return Object.keys(query).every(function(prop) {
                    return query[prop] === item[prop];
                });
            });
            result.sort(function(a, b) {
                if (a.speed < b.speed) return -1;
                if (a.speed > b.speed) return 1;
                return 0;
            })

            return result;

        },
        spellcast: function(casterName, spellName, targetUnitId) {

        },
        battle: function(attacker, defender) {

        }
    };

    return battlemanager;
}