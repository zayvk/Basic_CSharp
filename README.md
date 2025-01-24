graph TD
    subgraph "GitHub"
        Repo1["Repository 1"]
        Repo2["Repository 2"]
        Repo3["Repository 3"]
    end

    subgraph "Azure DevOps Pipelines"
        BuildPipe1Main["Build Pipeline 1 (Main)"]
        BuildPipe1PR["Build Pipeline 1 (PR)"]
        ReleasePipe1["Release Pipeline 1"]

        BuildPipe2Main["Build Pipeline 2 (Main)"]
        BuildPipe2PR["Build Pipeline 2 (PR)"]
        ReleasePipe2["Release Pipeline 2"]

        BuildPipe3Main["Build Pipeline 3 (Main)"]
        BuildPipe3PR["Build Pipeline 3 (PR)"]
        ReleasePipe3["Release Pipeline 3"]
    end

    subgraph "Build Agents (Load Balanced)"
        Agent1["Windows Server 1"]
        Agent2["Windows Server 2"]
    end

    Repo1 --> BuildPipe1Main --> Agent1 & Agent2
    Repo1 --> BuildPipe1PR --> Agent1 & Agent2
    BuildPipe1Main & BuildPipe1PR --> ReleasePipe1

    Repo2 --> BuildPipe2Main --> Agent1 & Agent2
    Repo2 --> BuildPipe2PR --> Agent1 & Agent2
    BuildPipe2Main & BuildPipe2PR --> ReleasePipe2

    Repo3 --> BuildPipe3Main --> Agent1 & Agent2
    Repo3 --> BuildPipe3PR --> Agent1 & Agent2
    BuildPipe3Main & BuildPipe3PR --> ReleasePipe3

    style Agent1 fill:#a3d3f5,stroke:#036,stroke-width:2px
    style Agent2 fill:#a3d3f5,stroke:#036,stroke-width:2px
