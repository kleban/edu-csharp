using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo.Model
{
    public class SubscriptionManager
    {
        private List<Subscription> subscriptions = new List<Subscription>();

        public SubscriptionManager()
        {
            subscriptions.Add(new Subscription { Id = 1, Title = "Light", Price = 350 });
            subscriptions.Add(new Subscription { Id = 2, Title = "Medium", Price = 750 });
            subscriptions.Add(new Subscription { Id = 3, Title = "Hard", Price = 1050 });
        }

        public List<Subscription> GetSubscriptions() 
        {
            return subscriptions;
        }

        public void Add(Subscription subscription)
        {
            subscriptions.Add(subscription);
        }
    }
}
