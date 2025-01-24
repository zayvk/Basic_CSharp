graph TD
    A[GitHub Repo 1] --> B[Main Build Pipeline]
    A --> C[PR Build Pipeline]
    A --> D[Release Pipeline]
    
    E[GitHub Repo 2] --> F[Main Build Pipeline]
    E --> G[PR Build Pipeline]
    E --> H[Release Pipeline]
    
    I[GitHub Repo 3] --> J[Main Build Pipeline]
    I --> K[PR Build Pipeline]
    I --> L[Release Pipeline]
    
    B --> M[Windows Agent Server 1]
    C --> M[Windows Agent Server 1]
    F --> N[Windows Agent Server 2]
    G --> N[Windows Agent Server 2]
    J --> M[Windows Agent Server 1]
    K --> N[Windows Agent Server 2]
    
    classDef repo fill:#ffcc00;
    class A,E,I repo;
    classDef pipeline fill:#99ccff;
    class B,C,D,F,G,H,J,K,L pipeline;
    classDef agent fill:#66ff66;
    class M,N agent;
