using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Color
{
    WHITE, GREY, BLACK
}

namespace BetterGraphSolver
{
    public class FlowGraph
    {
        int V;
        public int[,] capacity; // Матрица пропускных способнотей
        int[,] flow; // Матрица потока
        int[] color; // Цвета для вершин
        int[] pred; // Массив пути
        int head, tail; // Начало, Конец
        int[] q; // Очередь, хранящая номера вершин входящих в неё

        public FlowGraph(int V)
        {
            this.V = V;
            capacity = new int[V, V];
            flow = new int[V, V];
            color = new int[V];
            pred = new int[V];
            q = new int[V + 2];
        }

        int min(int x, int y)
        {
            if (x < y)
                return x;
            else
                return y;
        }

        void enque(int x)
        {
            q[tail] = x;     // записать х в хвост
            tail++;          // хвостом становиться следующий элемент
            color[x] = (int)Color.GREY; // Цвет серый (из алгоритма поиска)
        }

        int deque()
        {
            int x = q[head];  // Записать в х значение головы
            head++;           // Соответственно номер начала очереди увеличивается
            color[x] = (int)Color.BLACK; // Вершина х - отмечается как прочитанная
            return x;         // Возвращается номер х прочитанной вершины
        }

        int bfs(int start, int end)
        {
            int u, v;
            for (u = 0; u < V; u++) // Сначала отмечаем все вершины не пройденными
                color[u] = (int)Color.WHITE;

            head = 0;   // Начало очереди 0
            tail = 0;   // Хвост 0
            enque(start);      // Вступили на первую вершину
            pred[start] = -1;   // Специальная метка для начала пути
            while (head != tail)  // Пока хвост не совпадёт с головой
            {
                u = deque();       // вершина u пройдена
                for (v = 0; v < V; v++) // Смотрим смежные вершины
                {
                    // Если не пройдена и не заполнена
                    if (color[v] == (int)Color.WHITE && (capacity[u, v] - flow[u, v]) > 0)
                    {
                        enque(v);  // Вступаем на вершину v
                        pred[v] = u; // Путь обновляем
                    }
                }
            }
            if (color[end] == (int)Color.BLACK) // Если конечная вершина, дошли - возвращаем 0
                return 0;
            else return 1;
        }

        int maxFlow(int source, int stock)
        {
            int i, j, u;
            int maxflow = 0;            // Изначально нулевой
            for (i = 0; i < V; i++)  // Зануляем матрицу потока
            {
                for (j = 0; j < V; j++)
                    flow[i,j] = 0;
            }
            while (bfs(source, stock) == 0)             // Пока сеществует путь
            {
                int delta = 10000;
                for (u = V - 1; pred[u] >= 0; u = pred[u]) // Найти минимальный поток в сети
                {
                    delta = min(delta, (capacity[pred[u],u] - flow[pred[u],u]));
                }
                for (u = V - 1; pred[u] >= 0; u = pred[u]) // По алгоритму Форда-Фалкерсона 
                {
                    flow[pred[u],u] += delta;
                    flow[u,pred[u]] -= delta;
                }
                maxflow += delta;                       // Повышаем максимальный поток
            }
            return maxflow;
        }


        public int kEdgeConnectivity()
        {
            int ans = int.MaxValue;

            for (int s = 0; s < V; s++)
                for (int t = s + 1; t < V; t++)
                {
                    int flow = maxFlow(s, t);
                    ans = Math.Min(ans, flow);
                }

            return ans;
        }

        int[,] twiceVertx()
        {
            int[,] res = new int[V * 2, V * 2];

            //Раздваиваем вершины, присваиваем входящие и выходящие ребра
            for (int i = 0; i < V; i++)
            {

                for (int j = 0; j < V; j++)
                {
                    res[i, j] = 0;
                    res[i + V, j + V] = 0;
                    res[i + V, j] = i != j ? capacity[i, j] : 1;
                    res[i, j + V] = i != j ? capacity[i, j] : 1;
                }
                
            }

            return res;
        } 

        public int kVertConnectivity()
        {
            int ans = int.MaxValue;

            int[,] g = capacity;
            capacity = twiceVertx();
            flow = new int[V * 2, V * 2];
            color = new int[V * 2];
            pred = new int[V * 2];
            q = new int[2 * V + 2];

            for (int s = 0; s < 2*V; s++)
                for (int t = s + 1; t < 2*V; t++)
                {
                    int flow = maxFlow(s, t);
                    ans = Math.Min(ans, flow);
                }

            capacity = g;
            flow = new int[V, V];
            color = new int[V];
            pred = new int[V];
            q = new int[V + 2];

            return ans;
        }

    }
}
