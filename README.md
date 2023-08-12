# Gilded Rose Starter

A starting point for the Gilded Rose kata using dotnet core, C#, and xunit.

## Give a Star! :star:

If you like or are using this project to learn, please give it a star. Thanks!

## Watch online

If you'd like to see how I complete this kata, I use it to demonstrate several refactoring techniques in my [Pluralsight Refactoring Fundamentals course](https://www.pluralsight.com/courses/refactoring-fundamentals).

# More Katas

https://github.com/ardalis/kata-catalog

Gilded Rose Kata
============
Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

# English

## Background

This kata puts you in the role of having to work with someone else's code. It is highly suggested that you use test-first development with this kata.

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a prominent city run by a friendly innkeeper named Allison. We also buy and sell only the finest goods. Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We have a system in place that updates our inventory for us. It was developed by a no-nonsense type named Leeroy, who has moved on to new adventures. The UpdateQuality() method is called each morning by another part of our system. Your task is to add the new feature to our system so that we can begin selling a new category of items. First an introduction to our system:

- All items have a SellIn value which denotes the number of days we have to sell the item
- All items have a Quality value which denotes how valuable the item is
- At the end of each day our system lowers both values for every item

Pretty simple, right? Well, this is where it gets interesting:

- Once the sell by date has passed, Quality degrades twice as fast
- The Quality of an item is never negative
- "Aged Brie" actually increases in Quality the older it gets
- The Quality of an item is never more than 50
- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches
	- Quality increases by 2 when there are 10 days or less
	- Quality increases by 3 when there are 5 days or less
	- but Quality drops to 0 after the concert

## Instructions

We have recently signed a supplier of conjured items. This requires an update to our system:

- "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything still works correctly. However, **do not alter the Item class or Items property** as those belong to the goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code ownership (you can make the UpdateQuality method and Items property static if you like, we'll cover for you).

Just for clarification, an item can never have its Quality increased above 50, however "Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.

# Français

## Background
Bonjour et bienvenue dans l'équipe Gilded Rose. Comme vous le savez, nous sommes une petite auberge bénéficiant d'un emplacement de choix dans une ville importante, dirigée par une aubergiste sympathique du nom d'Allison. Nous n'achetons et ne vendons que les produits les plus raffinés. Malheureusement, la qualité de nos produits ne cesse de se dégrader à mesure qu'ils approchent de leur date de péremption. Nous avons mis en place un système qui met à jour notre inventaire à notre place. Ce système a été mis au point par un type sans état d'âme nommé Leeroy, qui est parti vers de nouvelles aventures. La méthode UpdateQuality() est appelée chaque matin par une autre partie de notre système. Votre tâche consiste à ajouter la nouvelle fonctionnalité à notre système afin que nous puissions commencer à vendre une nouvelle catégorie d'articles. Tout d'abord, une introduction à notre système :

- Tous les articles ont une valeur SellIn qui indique le nombre de jours dont nous disposons pour vendre l'article.
- Tous les objets ont une valeur de qualité qui indique la valeur de l'objet.
- À la fin de chaque journée, notre système réduit les deux valeurs pour chaque article.

C'est assez simple, n'est-ce pas ? C'est là que les choses deviennent intéressantes :
- Une fois la date de péremption dépassée, la qualité se dégrade deux fois plus vite.
- La qualité d'un produit n'est jamais négative
- Le "Aged Brie" gagne en qualité au fur et à mesure qu'il vieillit.
- La qualité d'un article n'est jamais supérieure à 50
- Le "Sulfuras", étant un objet légendaire, n'a jamais besoin d'être vendu et sa qualité ne diminue jamais.
- Les "Backstage passes", comme le Aged Brie, augmentent leur qualité à mesure que leur valeur de vente approche.
	- La qualité augmente de 2 lorsqu'il y a 10 jours ou moins
	- La qualité augmente de 3 lorsqu'il y a 5 jours ou moins
	- mais la qualité tombe à 0 après le concert

## Instructions

Nous avons récemment signé un contrat avec un fournisseur d'articles de prestidigitation. Cela nécessite une mise à jour de notre système :

    Les objets "Conjured" se dégradent en qualité deux fois plus vite que les objets normaux.

N'hésitez pas à modifier la méthode UpdateQuality et à ajouter du code tant que tout fonctionne correctement. Cependant, ne modifiez pas la classe Item ou la propriété Items car elles appartiennent au gobelin dans le coin qui va insta-rager et vous tirer dessus car il ne croit pas au partage de la propriété du code (vous pouvez rendre la méthode UpdateQuality et la propriété Items statiques si vous le souhaitez, nous vous couvrirons).

Pour clarifier les choses, un objet ne peut jamais voir sa qualité augmenter au-delà de 50, mais "Sulfuras" est un objet légendaire et, à ce titre, sa qualité est de 80 et ne se modifie jamais.

## Extra Credit ##

- Item categories are determined by whether they contain a given string in their name (e.g. "Aged Brie" or "Sulfuras" or "Backstage passes")
- Any item can thus be conjured, with the resulting effects (e.g. "Conjured Backstage passes")

# Resources #
- [Original Source by Bobby Johnson (NotMyself) on GitHub](https://github.com/NotMyself/GildedRose)
- [Starting code in many languages](https://github.com/emilybache/GildedRose-Refactoring-Kata)