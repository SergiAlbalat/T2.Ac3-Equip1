### Integrants del grup 1:
- Sergi Albalat Duran
- Eudald Fajula Fernandez
- Oriol Font Garcia
- Izan Gonzalez Jimenez
- Unai Arévalo Marauri

## Link al disseny de proves
[Disseny de proves](https://docs.google.com/spreadsheets/d/1JZWPXwHSRo2cosmTPfD6TAL_5auWIHaDZF-WjrjSvyY/edit?usp=sharing)

# Rúbrica Avaluació grup 1 
## Pseudocodi
| Criteri | 2 | 1 | 0 | Puntuació |
| ------ | ------ | ------ | ------ | ------ |
| Robust | El programa funciona al 100% i no hi ha errors  | El programa NO funciona al 100%. Hi ha errors  | El programa NO funciona (hi ha errors estructurals) | 0 |
| Correcte | La implementació de la solució és correcta al 100% | La implementació de la solució NO és correcta al 100% (no cobreix alguns casos)  | La implementació és mínima | 1 |
| Sintaxi |  La notació (variables, estructures,...) és correcta al 100%. Els noms són prou autodescriptius | La notació (variables, estructures,...) NO és correcta al 100%. Els noms no són prou autodescriptius en tots els casos | No se segueix la notació vista a classe | 2 |
| Comentaris | El pseudocodi conté la PRE i POST i els comentaris necessaris | Falta algun element (PRE, POST, comentaris necessaris) | No hi ha cap element (PRE, POST, comentaris necessaris) | 2 |

**Observacions:**

La funcio nameselect demana dos arguments i quan la criden nomes introdueixen un. Les condicions OR estan mal escrites.

La funció nameselect en comptes de mirar la longitud del nom mira les vocals aixi que si de nom poses Als per exemple no ho acceptara. La força super4 que ha de repartir el 5% entre els 4 nomes dona el 5% a un.

**Puntuació total:** 5/8
## Flowchart
| Criteri | 2 | 1 | 0 | Puntuació |
| ------ | ------ | ------ | ------ | ------ |
| Robust | El programa funciona al 100% i no hi ha errors  | El programa NO funciona al 100%. Hi ha errors  | El programa NO funciona (hi ha errors estructurals) | 2 |
| Correcte | La implementació de la solució és correcta al 100% | La implementació de la solució NO és correcta al 100% (no cobreix alguns casos)  | La implementació és mínima | 1 |
| Sintaxi |  La notació (variables, símbols d'estructures,...) és correcta al 100%. Els noms són prou autodescriptius | La notació (variables, símbols d'estructures,...) NO és correcta al 100%. Els noms no són prou autodescriptius en tots els casos | No se segueix la notació vista a classe | 1 |
| Comentaris | El diagrama conté la PRE i POST i els comentaris necessaris (mitjançant anotacions) | Falta algun element (PRE, POST, comentaris necessaris) | No hi ha cap element (PRE, POST, comentaris necessaris) | 0 |

**Observacions:**

Hi han condicions poc clares, maldat i numAvatar no s'expliquen prou bé, ja que no en sé els valors que s'esperen.

La consistència en els noms, s'hauría d'uniformitzar l'ús de majúscules i minúscules i evitar barrejar idiomes (anglés amb el català) en les variables, ja que pot confondre.

Per últim, la finalitat, nosaltres ja ho sabem però el client potser no, a CheckAvatarName, comptes vocals però no es pot saber per què. S'ha d'assegurar que cada pas tingui un objectiu clar.

**Puntuació total:** 4/8

# Rúbrica Avaluació grup X
## Implementació en C#
| Criteri | 2 | 1 | 0 | Puntuació |
| ------ | ------ | ------ | ------ | ------ |
| Robust | El programa funciona al 100% i no hi ha errors (ni en compilació ni en execució)  | El programa NO funciona al 100%. Hi ha errors (en compilació o en execució)  | El programa NO funciona (hi ha errors estructurals) |  |
| Correcte | La implementació de la solució és correcta al 100% | La implementació de la solució NO és correcta al 100% (no cobreix alguns casos)  | La implementació és mínima |  |
| Sintaxi |  La notació (variables, estructures,...) és correcta al 100%, seguint les best practices de la comunitat. Els noms són prou autodescriptius | La notació (variables, estructures,...) NO és correcta al 100% (no segueix les best practices en tots els casos). Els noms no són prou autodescriptius en tots els casos | No se segueix la notació vista a classe |  |
| Comentaris | El pseudocodi conté la PRE i POST i els comentaris necessaris | Falta algun element (PRE, POST, comentaris necessaris) | No hi ha cap element (PRE, POST, comentaris necessaris) |  |

**Observacions:**

**Puntuació total:**

## Testing

```
using LibraryT2AC3;

namespace TestT2AC3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AvatarWith3()
        {
            //Arrange
            int min = 1;
            int max = 4;
            int input = 3;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(3,result); //No ERROR
        }
        [TestMethod]
        public void AvatarWith0()
        {
            //Arrange
            int min = 1;
            int max = 4;
            int input = 0;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(0, result); //ERROR, resultat esperat
        }
        [TestMethod]
        public void AvatarWith5()
        {
            //Arrange
            int min = 1;
            int max = 4;
            int input = 5;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(5, result); //ERROR, resultat esperat
        }
        [TestMethod]
        public void EvilWith3000()
        {
            //Arrange
            int min = 1000;
            int max = 50000;
            int input = 3000;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(3000, result); //No ERROR
        }
        [TestMethod]
        public void EvilWith20()
        {
            //Arrange
            int min = 1000;
            int max = 50000;
            int input = 20;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(20, result); //ERROR, resultat esperat
        }
        [TestMethod]
        public void EvilWith50001()
        {
            //Arrange
            int min = 1000;
            int max = 50000;
            int input = 50001;
            string CHOOSE_AVATAR = "Escoge el avatar entre 1 i 4: ";
            //Act
            int result = Library.checkInput(min, max, CHOOSE_AVATAR, input);
            //Assert
            Assert.AreEqual(50001, result); //ERROR, resultat esperat
        }

    }
}
```
**Observacions:**
