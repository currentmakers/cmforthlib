\
\ @file risaf.fs
\ @brief Resource isolation slave unit for address space protection
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RISAF configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_CR_GLOCK                             \ global lock


\
\ @brief RISAF illegal access status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_IASR_CAEF                            \ configuration access error flag
$00000002 constant RISAF_RISAF_IASR_IAEF                            \ illegal access error flag


\
\ @brief RISAF illegal access clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_IACR_CAEF                            \ configuration access error flag
$00000002 constant RISAF_RISAF_IACR_IAEF                            \ illegal access error flag


\
\ @brief RISAF illegal access error status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000007 constant RISAF_RISAF_IAESR_IACID                          \ illegal access compartment ID
$00000010 constant RISAF_RISAF_IAESR_IAPRIV                         \ illegal access privileged
$00000020 constant RISAF_RISAF_IAESR_IASEC                          \ illegal access security
$00000080 constant RISAF_RISAF_IAESR_IANRW                          \ illegal access read/write


\
\ @brief RISAF illegal address register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_IADDR_IADD                           \ illegal address


\
\ @brief RISAF region 1 configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG1_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG1_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG1_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG1_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG1_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG1_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG1_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG1_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG1_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG1_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 1 start-address register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG1_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 1 end-address register
\ Address offset: 0x48
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG1_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 1 CID configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG1_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG1_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG1_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG1_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG1_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG1_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG1_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG1_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG1_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 1 subregion A configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG1_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG1_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG1_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG1_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG1_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG1_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG1_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 1 subregion A start-address register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG1_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 1 subregion A end-address register
\ Address offset: 0x58
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG1_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 1 subregion A nested mode register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG1_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 1 subregion B configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG1_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG1_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG1_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG1_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG1_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG1_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG1_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 1 subregion B start-address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG1_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 1 subregion B end-address register
\ Address offset: 0x68
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG1_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 1 subregion B nested mode register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG1_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 2 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG2_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG2_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG2_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG2_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG2_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG2_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG2_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG2_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG2_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG2_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 2 start-address register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG2_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 2 end-address register
\ Address offset: 0x88
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG2_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 2 CID configuration register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG2_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG2_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG2_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG2_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG2_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG2_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG2_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG2_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG2_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 2 subregion A configuration register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG2_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG2_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG2_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG2_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG2_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG2_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG2_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 2 subregion A start-address register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG2_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 2 subregion A end-address register
\ Address offset: 0x98
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG2_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 2 subregion A nested mode register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG2_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 2 subregion B configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG2_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG2_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG2_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG2_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG2_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG2_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG2_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 2 subregion B start-address register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG2_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 2 subregion B end-address register
\ Address offset: 0xA8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG2_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 2 subregion B nested mode register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG2_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 3 configuration register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG3_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG3_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG3_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG3_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG3_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG3_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG3_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG3_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG3_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG3_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 3 start-address register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG3_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 3 end-address register
\ Address offset: 0xC8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG3_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 3 CID configuration register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG3_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG3_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG3_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG3_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG3_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG3_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG3_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG3_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG3_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 3 subregion A configuration register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG3_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG3_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG3_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG3_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG3_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG3_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG3_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 3 subregion A start-address register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG3_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 3 subregion A end-address register
\ Address offset: 0xD8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG3_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 3 subregion A nested mode register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG3_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 3 subregion B configuration register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG3_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG3_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG3_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG3_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG3_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG3_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG3_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 3 subregion B start-address register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG3_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 3 subregion B end-address register
\ Address offset: 0xE8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG3_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 3 subregion B nested mode register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG3_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 4 configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG4_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG4_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG4_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG4_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG4_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG4_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG4_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG4_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG4_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG4_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 4 start-address register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG4_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 4 end-address register
\ Address offset: 0x108
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG4_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 4 CID configuration register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG4_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG4_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG4_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG4_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG4_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG4_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG4_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG4_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG4_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 4 subregion A configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG4_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG4_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG4_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG4_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG4_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG4_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG4_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 4 subregion A start-address register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG4_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 4 subregion A end-address register
\ Address offset: 0x118
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG4_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 4 subregion A nested mode register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG4_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 4 subregion B configuration register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG4_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG4_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG4_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG4_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG4_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG4_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG4_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 4 subregion B start-address register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG4_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 4 subregion B end-address register
\ Address offset: 0x128
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG4_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 4 subregion B nested mode register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG4_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 5 configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG5_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG5_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG5_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG5_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG5_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG5_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG5_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG5_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG5_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG5_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 5 start-address register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG5_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 5 end-address register
\ Address offset: 0x148
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG5_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 5 CID configuration register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG5_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG5_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG5_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG5_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG5_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG5_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG5_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG5_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG5_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 5 subregion A configuration register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG5_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG5_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG5_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG5_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG5_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG5_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG5_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 5 subregion A start-address register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG5_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 5 subregion A end-address register
\ Address offset: 0x158
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG5_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 5 subregion A nested mode register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG5_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 5 subregion B configuration register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG5_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG5_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG5_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG5_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG5_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG5_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG5_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 5 subregion B start-address register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG5_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 5 subregion B end-address register
\ Address offset: 0x168
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG5_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 5 subregion B nested mode register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG5_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 6 configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG6_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG6_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG6_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG6_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG6_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG6_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG6_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG6_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG6_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG6_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 6 start-address register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG6_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 6 end-address register
\ Address offset: 0x188
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG6_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 6 CID configuration register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG6_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG6_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG6_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG6_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG6_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG6_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG6_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG6_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG6_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 6 subregion A configuration register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG6_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG6_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG6_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG6_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG6_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG6_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG6_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 6 subregion A start-address register
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG6_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 6 subregion A end-address register
\ Address offset: 0x198
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG6_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 6 subregion A nested mode register
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG6_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 6 subregion B configuration register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG6_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG6_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG6_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG6_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG6_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG6_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG6_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 6 subregion B start-address register
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG6_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 6 subregion B end-address register
\ Address offset: 0x1A8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG6_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 6 subregion B nested mode register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG6_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 7 configuration register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG7_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG7_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG7_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG7_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG7_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG7_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG7_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG7_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG7_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG7_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 7 start-address register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG7_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 7 end-address register
\ Address offset: 0x1C8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG7_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 7 CID configuration register
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG7_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG7_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG7_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG7_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG7_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG7_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG7_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG7_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG7_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 7 subregion A configuration register
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG7_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG7_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG7_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG7_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG7_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG7_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG7_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 7 subregion A start-address register
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG7_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 7 subregion A end-address register
\ Address offset: 0x1D8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG7_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 7 subregion A nested mode register
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG7_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 7 subregion B configuration register
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG7_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG7_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG7_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG7_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG7_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG7_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG7_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 7 subregion B start-address register
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG7_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 7 subregion B end-address register
\ Address offset: 0x1E8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG7_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 7 subregion B nested mode register
\ Address offset: 0x1EC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG7_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 8 configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG8_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG8_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG8_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG8_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG8_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG8_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG8_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG8_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG8_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG8_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 8 start-address register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG8_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 8 end-address register
\ Address offset: 0x208
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG8_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 8 CID configuration register
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG8_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG8_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG8_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG8_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG8_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG8_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG8_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG8_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG8_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 8 subregion A configuration register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG8_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG8_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG8_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG8_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG8_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG8_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG8_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 8 subregion A start-address register
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG8_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 8 subregion A end-address register
\ Address offset: 0x218
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG8_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 8 subregion A nested mode register
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG8_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 8 subregion B configuration register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG8_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG8_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG8_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG8_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG8_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG8_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG8_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 8 subregion B start-address register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG8_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 8 subregion B end-address register
\ Address offset: 0x228
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG8_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 8 subregion B nested mode register
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG8_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 9 configuration register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG9_CFGR_BREN                       \ base region enable
$00000100 constant RISAF_RISAF_REG9_CFGR_SEC                        \ secure region
$00010000 constant RISAF_RISAF_REG9_CFGR_PRIVC0                     \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG9_CFGR_PRIVC1                     \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG9_CFGR_PRIVC2                     \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG9_CFGR_PRIVC3                     \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG9_CFGR_PRIVC4                     \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG9_CFGR_PRIVC5                     \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG9_CFGR_PRIVC6                     \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG9_CFGR_PRIVC7                     \ privileged access for compartment y


\
\ @brief RISAF region 9 start-address register
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG9_STARTR_BADDSTART                \ Base region address start


\
\ @brief RISAF region 9 end-address register
\ Address offset: 0x248
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG9_ENDR_BADDEND                    \ Base region address end


\
\ @brief RISAF region 9 CID configuration register
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG9_CIDCFGR_RDENC0                  \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG9_CIDCFGR_RDENC1                  \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG9_CIDCFGR_RDENC2                  \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG9_CIDCFGR_RDENC3                  \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG9_CIDCFGR_RDENC4                  \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG9_CIDCFGR_RDENC5                  \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG9_CIDCFGR_RDENC6                  \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG9_CIDCFGR_RDENC7                  \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC0                  \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC1                  \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC2                  \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC3                  \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC4                  \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC5                  \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC6                  \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG9_CIDCFGR_WRENC7                  \ write enable for compartment y


\
\ @brief RISAF region 9 subregion A configuration register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG9_ACFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG9_ACFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG9_ACFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG9_ACFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG9_ACFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG9_ACFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG9_ACFGR_WREN                      \ write enable


\
\ @brief RISAF region 9 subregion A start-address register
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG9_ASTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 9 subregion A end-address register
\ Address offset: 0x258
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG9_AENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 9 subregion A nested mode register
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG9_ANESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 9 subregion B configuration register
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG9_BCFGR_SREN                      \ subregion enable
$00000002 constant RISAF_RISAF_REG9_BCFGR_RLOCK                     \ resource lock
$00000070 constant RISAF_RISAF_REG9_BCFGR_SRCID                     \ subregion CID
$00000100 constant RISAF_RISAF_REG9_BCFGR_SEC                       \ secure subregion
$00000200 constant RISAF_RISAF_REG9_BCFGR_PRIV                      \ privileged subregion
$00001000 constant RISAF_RISAF_REG9_BCFGR_RDEN                      \ read enable
$00002000 constant RISAF_RISAF_REG9_BCFGR_WREN                      \ write enable


\
\ @brief RISAF region 9 subregion B start-address register
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG9_BSTARTR_SADDSTART               \ subregion address start


\
\ @brief RISAF region 9 subregion B end-address register
\ Address offset: 0x268
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG9_BENDR_SADDEND                   \ subregion address end


\
\ @brief RISAF region 9 subregion B nested mode register
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG9_BNESTR_DCEN                     \ delegated configuration enable


\
\ @brief RISAF region 10 configuration register
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG10_CFGR_BREN                      \ base region enable
$00000100 constant RISAF_RISAF_REG10_CFGR_SEC                       \ secure region
$00010000 constant RISAF_RISAF_REG10_CFGR_PRIVC0                    \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG10_CFGR_PRIVC1                    \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG10_CFGR_PRIVC2                    \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG10_CFGR_PRIVC3                    \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG10_CFGR_PRIVC4                    \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG10_CFGR_PRIVC5                    \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG10_CFGR_PRIVC6                    \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG10_CFGR_PRIVC7                    \ privileged access for compartment y


\
\ @brief RISAF region 10 start-address register
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG10_STARTR_BADDSTART               \ Base region address start


\
\ @brief RISAF region 10 end-address register
\ Address offset: 0x288
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG10_ENDR_BADDEND                   \ Base region address end


\
\ @brief RISAF region 10 CID configuration register
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG10_CIDCFGR_RDENC0                 \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG10_CIDCFGR_RDENC1                 \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG10_CIDCFGR_RDENC2                 \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG10_CIDCFGR_RDENC3                 \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG10_CIDCFGR_RDENC4                 \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG10_CIDCFGR_RDENC5                 \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG10_CIDCFGR_RDENC6                 \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG10_CIDCFGR_RDENC7                 \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC0                 \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC1                 \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC2                 \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC3                 \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC4                 \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC5                 \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC6                 \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG10_CIDCFGR_WRENC7                 \ write enable for compartment y


\
\ @brief RISAF region 10 subregion A configuration register
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG10_ACFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG10_ACFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG10_ACFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG10_ACFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG10_ACFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG10_ACFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG10_ACFGR_WREN                     \ write enable


\
\ @brief RISAF region 10 subregion A start-address register
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG10_ASTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 10 subregion A end-address register
\ Address offset: 0x298
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG10_AENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 10 subregion A nested mode register
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG10_ANESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 10 subregion B configuration register
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG10_BCFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG10_BCFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG10_BCFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG10_BCFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG10_BCFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG10_BCFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG10_BCFGR_WREN                     \ write enable


\
\ @brief RISAF region 10 subregion B start-address register
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG10_BSTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 10 subregion B end-address register
\ Address offset: 0x2A8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG10_BENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 10 subregion B nested mode register
\ Address offset: 0x2AC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG10_BNESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 11 configuration register
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG11_CFGR_BREN                      \ base region enable
$00000100 constant RISAF_RISAF_REG11_CFGR_SEC                       \ secure region
$00010000 constant RISAF_RISAF_REG11_CFGR_PRIVC0                    \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG11_CFGR_PRIVC1                    \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG11_CFGR_PRIVC2                    \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG11_CFGR_PRIVC3                    \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG11_CFGR_PRIVC4                    \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG11_CFGR_PRIVC5                    \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG11_CFGR_PRIVC6                    \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG11_CFGR_PRIVC7                    \ privileged access for compartment y


\
\ @brief RISAF region 11 start-address register
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG11_STARTR_BADDSTART               \ Base region address start


\
\ @brief RISAF region 11 end-address register
\ Address offset: 0x2C8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG11_ENDR_BADDEND                   \ Base region address end


\
\ @brief RISAF region 11 CID configuration register
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG11_CIDCFGR_RDENC0                 \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG11_CIDCFGR_RDENC1                 \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG11_CIDCFGR_RDENC2                 \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG11_CIDCFGR_RDENC3                 \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG11_CIDCFGR_RDENC4                 \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG11_CIDCFGR_RDENC5                 \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG11_CIDCFGR_RDENC6                 \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG11_CIDCFGR_RDENC7                 \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC0                 \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC1                 \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC2                 \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC3                 \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC4                 \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC5                 \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC6                 \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG11_CIDCFGR_WRENC7                 \ write enable for compartment y


\
\ @brief RISAF region 11 subregion A configuration register
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG11_ACFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG11_ACFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG11_ACFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG11_ACFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG11_ACFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG11_ACFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG11_ACFGR_WREN                     \ write enable


\
\ @brief RISAF region 11 subregion A start-address register
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG11_ASTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 11 subregion A end-address register
\ Address offset: 0x2D8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG11_AENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 11 subregion A nested mode register
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG11_ANESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 11 subregion B configuration register
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG11_BCFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG11_BCFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG11_BCFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG11_BCFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG11_BCFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG11_BCFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG11_BCFGR_WREN                     \ write enable


\
\ @brief RISAF region 11 subregion B start-address register
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG11_BSTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 11 subregion B end-address register
\ Address offset: 0x2E8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG11_BENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 11 subregion B nested mode register
\ Address offset: 0x2EC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG11_BNESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 12 configuration register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG12_CFGR_BREN                      \ base region enable
$00000100 constant RISAF_RISAF_REG12_CFGR_SEC                       \ secure region
$00010000 constant RISAF_RISAF_REG12_CFGR_PRIVC0                    \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG12_CFGR_PRIVC1                    \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG12_CFGR_PRIVC2                    \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG12_CFGR_PRIVC3                    \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG12_CFGR_PRIVC4                    \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG12_CFGR_PRIVC5                    \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG12_CFGR_PRIVC6                    \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG12_CFGR_PRIVC7                    \ privileged access for compartment y


\
\ @brief RISAF region 12 start-address register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG12_STARTR_BADDSTART               \ Base region address start


\
\ @brief RISAF region 12 end-address register
\ Address offset: 0x308
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG12_ENDR_BADDEND                   \ Base region address end


\
\ @brief RISAF region 12 CID configuration register
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG12_CIDCFGR_RDENC0                 \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG12_CIDCFGR_RDENC1                 \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG12_CIDCFGR_RDENC2                 \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG12_CIDCFGR_RDENC3                 \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG12_CIDCFGR_RDENC4                 \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG12_CIDCFGR_RDENC5                 \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG12_CIDCFGR_RDENC6                 \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG12_CIDCFGR_RDENC7                 \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC0                 \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC1                 \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC2                 \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC3                 \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC4                 \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC5                 \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC6                 \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG12_CIDCFGR_WRENC7                 \ write enable for compartment y


\
\ @brief RISAF region 12 subregion A configuration register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG12_ACFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG12_ACFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG12_ACFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG12_ACFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG12_ACFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG12_ACFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG12_ACFGR_WREN                     \ write enable


\
\ @brief RISAF region 12 subregion A start-address register
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG12_ASTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 12 subregion A end-address register
\ Address offset: 0x318
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG12_AENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 12 subregion A nested mode register
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG12_ANESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 12 subregion B configuration register
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG12_BCFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG12_BCFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG12_BCFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG12_BCFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG12_BCFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG12_BCFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG12_BCFGR_WREN                     \ write enable


\
\ @brief RISAF region 12 subregion B start-address register
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG12_BSTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 12 subregion B end-address register
\ Address offset: 0x328
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG12_BENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 12 subregion B nested mode register
\ Address offset: 0x32C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG12_BNESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 13 configuration register
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG13_CFGR_BREN                      \ base region enable
$00000100 constant RISAF_RISAF_REG13_CFGR_SEC                       \ secure region
$00010000 constant RISAF_RISAF_REG13_CFGR_PRIVC0                    \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG13_CFGR_PRIVC1                    \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG13_CFGR_PRIVC2                    \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG13_CFGR_PRIVC3                    \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG13_CFGR_PRIVC4                    \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG13_CFGR_PRIVC5                    \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG13_CFGR_PRIVC6                    \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG13_CFGR_PRIVC7                    \ privileged access for compartment y


\
\ @brief RISAF region 13 start-address register
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG13_STARTR_BADDSTART               \ Base region address start


\
\ @brief RISAF region 13 end-address register
\ Address offset: 0x348
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG13_ENDR_BADDEND                   \ Base region address end


\
\ @brief RISAF region 13 CID configuration register
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG13_CIDCFGR_RDENC0                 \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG13_CIDCFGR_RDENC1                 \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG13_CIDCFGR_RDENC2                 \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG13_CIDCFGR_RDENC3                 \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG13_CIDCFGR_RDENC4                 \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG13_CIDCFGR_RDENC5                 \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG13_CIDCFGR_RDENC6                 \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG13_CIDCFGR_RDENC7                 \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC0                 \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC1                 \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC2                 \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC3                 \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC4                 \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC5                 \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC6                 \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG13_CIDCFGR_WRENC7                 \ write enable for compartment y


\
\ @brief RISAF region 13 subregion A configuration register
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG13_ACFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG13_ACFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG13_ACFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG13_ACFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG13_ACFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG13_ACFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG13_ACFGR_WREN                     \ write enable


\
\ @brief RISAF region 13 subregion A start-address register
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG13_ASTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 13 subregion A end-address register
\ Address offset: 0x358
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG13_AENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 13 subregion A nested mode register
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG13_ANESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 13 subregion B configuration register
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG13_BCFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG13_BCFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG13_BCFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG13_BCFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG13_BCFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG13_BCFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG13_BCFGR_WREN                     \ write enable


\
\ @brief RISAF region 13 subregion B start-address register
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG13_BSTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 13 subregion B end-address register
\ Address offset: 0x368
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG13_BENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 13 subregion B nested mode register
\ Address offset: 0x36C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG13_BNESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 14 configuration register
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG14_CFGR_BREN                      \ base region enable
$00000100 constant RISAF_RISAF_REG14_CFGR_SEC                       \ secure region
$00010000 constant RISAF_RISAF_REG14_CFGR_PRIVC0                    \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG14_CFGR_PRIVC1                    \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG14_CFGR_PRIVC2                    \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG14_CFGR_PRIVC3                    \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG14_CFGR_PRIVC4                    \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG14_CFGR_PRIVC5                    \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG14_CFGR_PRIVC6                    \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG14_CFGR_PRIVC7                    \ privileged access for compartment y


\
\ @brief RISAF region 14 start-address register
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG14_STARTR_BADDSTART               \ Base region address start


\
\ @brief RISAF region 14 end-address register
\ Address offset: 0x388
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG14_ENDR_BADDEND                   \ Base region address end


\
\ @brief RISAF region 14 CID configuration register
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG14_CIDCFGR_RDENC0                 \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG14_CIDCFGR_RDENC1                 \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG14_CIDCFGR_RDENC2                 \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG14_CIDCFGR_RDENC3                 \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG14_CIDCFGR_RDENC4                 \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG14_CIDCFGR_RDENC5                 \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG14_CIDCFGR_RDENC6                 \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG14_CIDCFGR_RDENC7                 \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC0                 \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC1                 \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC2                 \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC3                 \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC4                 \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC5                 \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC6                 \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG14_CIDCFGR_WRENC7                 \ write enable for compartment y


\
\ @brief RISAF region 14 subregion A configuration register
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG14_ACFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG14_ACFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG14_ACFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG14_ACFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG14_ACFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG14_ACFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG14_ACFGR_WREN                     \ write enable


\
\ @brief RISAF region 14 subregion A start-address register
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG14_ASTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 14 subregion A end-address register
\ Address offset: 0x398
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG14_AENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 14 subregion A nested mode register
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG14_ANESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 14 subregion B configuration register
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG14_BCFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG14_BCFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG14_BCFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG14_BCFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG14_BCFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG14_BCFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG14_BCFGR_WREN                     \ write enable


\
\ @brief RISAF region 14 subregion B start-address register
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG14_BSTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 14 subregion B end-address register
\ Address offset: 0x3A8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG14_BENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 14 subregion B nested mode register
\ Address offset: 0x3AC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG14_BNESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 15 configuration register
\ Address offset: 0x3C0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG15_CFGR_BREN                      \ base region enable
$00000100 constant RISAF_RISAF_REG15_CFGR_SEC                       \ secure region
$00010000 constant RISAF_RISAF_REG15_CFGR_PRIVC0                    \ privileged access for compartment y
$00020000 constant RISAF_RISAF_REG15_CFGR_PRIVC1                    \ privileged access for compartment y
$00040000 constant RISAF_RISAF_REG15_CFGR_PRIVC2                    \ privileged access for compartment y
$00080000 constant RISAF_RISAF_REG15_CFGR_PRIVC3                    \ privileged access for compartment y
$00100000 constant RISAF_RISAF_REG15_CFGR_PRIVC4                    \ privileged access for compartment y
$00200000 constant RISAF_RISAF_REG15_CFGR_PRIVC5                    \ privileged access for compartment y
$00400000 constant RISAF_RISAF_REG15_CFGR_PRIVC6                    \ privileged access for compartment y
$00800000 constant RISAF_RISAF_REG15_CFGR_PRIVC7                    \ privileged access for compartment y


\
\ @brief RISAF region 15 start-address register
\ Address offset: 0x3C4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG15_STARTR_BADDSTART               \ Base region address start


\
\ @brief RISAF region 15 end-address register
\ Address offset: 0x3C8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG15_ENDR_BADDEND                   \ Base region address end


\
\ @brief RISAF region 15 CID configuration register
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG15_CIDCFGR_RDENC0                 \ read enable for compartment y
$00000002 constant RISAF_RISAF_REG15_CIDCFGR_RDENC1                 \ read enable for compartment y
$00000004 constant RISAF_RISAF_REG15_CIDCFGR_RDENC2                 \ read enable for compartment y
$00000008 constant RISAF_RISAF_REG15_CIDCFGR_RDENC3                 \ read enable for compartment y
$00000010 constant RISAF_RISAF_REG15_CIDCFGR_RDENC4                 \ read enable for compartment y
$00000020 constant RISAF_RISAF_REG15_CIDCFGR_RDENC5                 \ read enable for compartment y
$00000040 constant RISAF_RISAF_REG15_CIDCFGR_RDENC6                 \ read enable for compartment y
$00000080 constant RISAF_RISAF_REG15_CIDCFGR_RDENC7                 \ read enable for compartment y
$00010000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC0                 \ write enable for compartment y
$00020000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC1                 \ write enable for compartment y
$00040000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC2                 \ write enable for compartment y
$00080000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC3                 \ write enable for compartment y
$00100000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC4                 \ write enable for compartment y
$00200000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC5                 \ write enable for compartment y
$00400000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC6                 \ write enable for compartment y
$00800000 constant RISAF_RISAF_REG15_CIDCFGR_WRENC7                 \ write enable for compartment y


\
\ @brief RISAF region 15 subregion A configuration register
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG15_ACFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG15_ACFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG15_ACFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG15_ACFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG15_ACFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG15_ACFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG15_ACFGR_WREN                     \ write enable


\
\ @brief RISAF region 15 subregion A start-address register
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG15_ASTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 15 subregion A end-address register
\ Address offset: 0x3D8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG15_AENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 15 subregion A nested mode register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG15_ANESTR_DCEN                    \ delegated configuration enable


\
\ @brief RISAF region 15 subregion B configuration register
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000001 constant RISAF_RISAF_REG15_BCFGR_SREN                     \ subregion enable
$00000002 constant RISAF_RISAF_REG15_BCFGR_RLOCK                    \ resource lock
$00000070 constant RISAF_RISAF_REG15_BCFGR_SRCID                    \ subregion CID
$00000100 constant RISAF_RISAF_REG15_BCFGR_SEC                      \ secure subregion
$00000200 constant RISAF_RISAF_REG15_BCFGR_PRIV                     \ privileged subregion
$00001000 constant RISAF_RISAF_REG15_BCFGR_RDEN                     \ read enable
$00002000 constant RISAF_RISAF_REG15_BCFGR_WREN                     \ write enable


\
\ @brief RISAF region 15 subregion B start-address register
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000000 constant RISAF_RISAF_REG15_BSTARTR_SADDSTART              \ subregion address start


\
\ @brief RISAF region 15 subregion B end-address register
\ Address offset: 0x3E8
\ Reset value: 0x00000FFF
\

$00000000 constant RISAF_RISAF_REG15_BENDR_SADDEND                  \ subregion address end


\
\ @brief RISAF region 15 subregion B nested mode register
\ Address offset: 0x3EC
\ Reset value: 0x00000000
\

$00000004 constant RISAF_RISAF_REG15_BNESTR_DCEN                    \ delegated configuration enable


\
\ @brief Resource isolation slave unit for address space protection
\
$44026000 constant RISAF_RISAF_CR  \ offset: 0x00 : RISAF configuration register
$44026008 constant RISAF_RISAF_IASR  \ offset: 0x08 : RISAF illegal access status register
$4402600c constant RISAF_RISAF_IACR  \ offset: 0x0C : RISAF illegal access clear register
$44026020 constant RISAF_RISAF_IAESR  \ offset: 0x20 : RISAF illegal access error status register
$44026024 constant RISAF_RISAF_IADDR  \ offset: 0x24 : RISAF illegal address register
$44026040 constant RISAF_RISAF_REG1_CFGR  \ offset: 0x40 : RISAF region 1 configuration register
$44026044 constant RISAF_RISAF_REG1_STARTR  \ offset: 0x44 : RISAF region 1 start-address register
$44026048 constant RISAF_RISAF_REG1_ENDR  \ offset: 0x48 : RISAF region 1 end-address register
$4402604c constant RISAF_RISAF_REG1_CIDCFGR  \ offset: 0x4C : RISAF region 1 CID configuration register
$44026050 constant RISAF_RISAF_REG1_ACFGR  \ offset: 0x50 : RISAF region 1 subregion A configuration register
$44026054 constant RISAF_RISAF_REG1_ASTARTR  \ offset: 0x54 : RISAF region 1 subregion A start-address register
$44026058 constant RISAF_RISAF_REG1_AENDR  \ offset: 0x58 : RISAF region 1 subregion A end-address register
$4402605c constant RISAF_RISAF_REG1_ANESTR  \ offset: 0x5C : RISAF region 1 subregion A nested mode register
$44026060 constant RISAF_RISAF_REG1_BCFGR  \ offset: 0x60 : RISAF region 1 subregion B configuration register
$44026064 constant RISAF_RISAF_REG1_BSTARTR  \ offset: 0x64 : RISAF region 1 subregion B start-address register
$44026068 constant RISAF_RISAF_REG1_BENDR  \ offset: 0x68 : RISAF region 1 subregion B end-address register
$4402606c constant RISAF_RISAF_REG1_BNESTR  \ offset: 0x6C : RISAF region 1 subregion B nested mode register
$44026080 constant RISAF_RISAF_REG2_CFGR  \ offset: 0x80 : RISAF region 2 configuration register
$44026084 constant RISAF_RISAF_REG2_STARTR  \ offset: 0x84 : RISAF region 2 start-address register
$44026088 constant RISAF_RISAF_REG2_ENDR  \ offset: 0x88 : RISAF region 2 end-address register
$4402608c constant RISAF_RISAF_REG2_CIDCFGR  \ offset: 0x8C : RISAF region 2 CID configuration register
$44026090 constant RISAF_RISAF_REG2_ACFGR  \ offset: 0x90 : RISAF region 2 subregion A configuration register
$44026094 constant RISAF_RISAF_REG2_ASTARTR  \ offset: 0x94 : RISAF region 2 subregion A start-address register
$44026098 constant RISAF_RISAF_REG2_AENDR  \ offset: 0x98 : RISAF region 2 subregion A end-address register
$4402609c constant RISAF_RISAF_REG2_ANESTR  \ offset: 0x9C : RISAF region 2 subregion A nested mode register
$440260a0 constant RISAF_RISAF_REG2_BCFGR  \ offset: 0xA0 : RISAF region 2 subregion B configuration register
$440260a4 constant RISAF_RISAF_REG2_BSTARTR  \ offset: 0xA4 : RISAF region 2 subregion B start-address register
$440260a8 constant RISAF_RISAF_REG2_BENDR  \ offset: 0xA8 : RISAF region 2 subregion B end-address register
$440260ac constant RISAF_RISAF_REG2_BNESTR  \ offset: 0xAC : RISAF region 2 subregion B nested mode register
$440260c0 constant RISAF_RISAF_REG3_CFGR  \ offset: 0xC0 : RISAF region 3 configuration register
$440260c4 constant RISAF_RISAF_REG3_STARTR  \ offset: 0xC4 : RISAF region 3 start-address register
$440260c8 constant RISAF_RISAF_REG3_ENDR  \ offset: 0xC8 : RISAF region 3 end-address register
$440260cc constant RISAF_RISAF_REG3_CIDCFGR  \ offset: 0xCC : RISAF region 3 CID configuration register
$440260d0 constant RISAF_RISAF_REG3_ACFGR  \ offset: 0xD0 : RISAF region 3 subregion A configuration register
$440260d4 constant RISAF_RISAF_REG3_ASTARTR  \ offset: 0xD4 : RISAF region 3 subregion A start-address register
$440260d8 constant RISAF_RISAF_REG3_AENDR  \ offset: 0xD8 : RISAF region 3 subregion A end-address register
$440260dc constant RISAF_RISAF_REG3_ANESTR  \ offset: 0xDC : RISAF region 3 subregion A nested mode register
$440260e0 constant RISAF_RISAF_REG3_BCFGR  \ offset: 0xE0 : RISAF region 3 subregion B configuration register
$440260e4 constant RISAF_RISAF_REG3_BSTARTR  \ offset: 0xE4 : RISAF region 3 subregion B start-address register
$440260e8 constant RISAF_RISAF_REG3_BENDR  \ offset: 0xE8 : RISAF region 3 subregion B end-address register
$440260ec constant RISAF_RISAF_REG3_BNESTR  \ offset: 0xEC : RISAF region 3 subregion B nested mode register
$44026100 constant RISAF_RISAF_REG4_CFGR  \ offset: 0x100 : RISAF region 4 configuration register
$44026104 constant RISAF_RISAF_REG4_STARTR  \ offset: 0x104 : RISAF region 4 start-address register
$44026108 constant RISAF_RISAF_REG4_ENDR  \ offset: 0x108 : RISAF region 4 end-address register
$4402610c constant RISAF_RISAF_REG4_CIDCFGR  \ offset: 0x10C : RISAF region 4 CID configuration register
$44026110 constant RISAF_RISAF_REG4_ACFGR  \ offset: 0x110 : RISAF region 4 subregion A configuration register
$44026114 constant RISAF_RISAF_REG4_ASTARTR  \ offset: 0x114 : RISAF region 4 subregion A start-address register
$44026118 constant RISAF_RISAF_REG4_AENDR  \ offset: 0x118 : RISAF region 4 subregion A end-address register
$4402611c constant RISAF_RISAF_REG4_ANESTR  \ offset: 0x11C : RISAF region 4 subregion A nested mode register
$44026120 constant RISAF_RISAF_REG4_BCFGR  \ offset: 0x120 : RISAF region 4 subregion B configuration register
$44026124 constant RISAF_RISAF_REG4_BSTARTR  \ offset: 0x124 : RISAF region 4 subregion B start-address register
$44026128 constant RISAF_RISAF_REG4_BENDR  \ offset: 0x128 : RISAF region 4 subregion B end-address register
$4402612c constant RISAF_RISAF_REG4_BNESTR  \ offset: 0x12C : RISAF region 4 subregion B nested mode register
$44026140 constant RISAF_RISAF_REG5_CFGR  \ offset: 0x140 : RISAF region 5 configuration register
$44026144 constant RISAF_RISAF_REG5_STARTR  \ offset: 0x144 : RISAF region 5 start-address register
$44026148 constant RISAF_RISAF_REG5_ENDR  \ offset: 0x148 : RISAF region 5 end-address register
$4402614c constant RISAF_RISAF_REG5_CIDCFGR  \ offset: 0x14C : RISAF region 5 CID configuration register
$44026150 constant RISAF_RISAF_REG5_ACFGR  \ offset: 0x150 : RISAF region 5 subregion A configuration register
$44026154 constant RISAF_RISAF_REG5_ASTARTR  \ offset: 0x154 : RISAF region 5 subregion A start-address register
$44026158 constant RISAF_RISAF_REG5_AENDR  \ offset: 0x158 : RISAF region 5 subregion A end-address register
$4402615c constant RISAF_RISAF_REG5_ANESTR  \ offset: 0x15C : RISAF region 5 subregion A nested mode register
$44026160 constant RISAF_RISAF_REG5_BCFGR  \ offset: 0x160 : RISAF region 5 subregion B configuration register
$44026164 constant RISAF_RISAF_REG5_BSTARTR  \ offset: 0x164 : RISAF region 5 subregion B start-address register
$44026168 constant RISAF_RISAF_REG5_BENDR  \ offset: 0x168 : RISAF region 5 subregion B end-address register
$4402616c constant RISAF_RISAF_REG5_BNESTR  \ offset: 0x16C : RISAF region 5 subregion B nested mode register
$44026180 constant RISAF_RISAF_REG6_CFGR  \ offset: 0x180 : RISAF region 6 configuration register
$44026184 constant RISAF_RISAF_REG6_STARTR  \ offset: 0x184 : RISAF region 6 start-address register
$44026188 constant RISAF_RISAF_REG6_ENDR  \ offset: 0x188 : RISAF region 6 end-address register
$4402618c constant RISAF_RISAF_REG6_CIDCFGR  \ offset: 0x18C : RISAF region 6 CID configuration register
$44026190 constant RISAF_RISAF_REG6_ACFGR  \ offset: 0x190 : RISAF region 6 subregion A configuration register
$44026194 constant RISAF_RISAF_REG6_ASTARTR  \ offset: 0x194 : RISAF region 6 subregion A start-address register
$44026198 constant RISAF_RISAF_REG6_AENDR  \ offset: 0x198 : RISAF region 6 subregion A end-address register
$4402619c constant RISAF_RISAF_REG6_ANESTR  \ offset: 0x19C : RISAF region 6 subregion A nested mode register
$440261a0 constant RISAF_RISAF_REG6_BCFGR  \ offset: 0x1A0 : RISAF region 6 subregion B configuration register
$440261a4 constant RISAF_RISAF_REG6_BSTARTR  \ offset: 0x1A4 : RISAF region 6 subregion B start-address register
$440261a8 constant RISAF_RISAF_REG6_BENDR  \ offset: 0x1A8 : RISAF region 6 subregion B end-address register
$440261ac constant RISAF_RISAF_REG6_BNESTR  \ offset: 0x1AC : RISAF region 6 subregion B nested mode register
$440261c0 constant RISAF_RISAF_REG7_CFGR  \ offset: 0x1C0 : RISAF region 7 configuration register
$440261c4 constant RISAF_RISAF_REG7_STARTR  \ offset: 0x1C4 : RISAF region 7 start-address register
$440261c8 constant RISAF_RISAF_REG7_ENDR  \ offset: 0x1C8 : RISAF region 7 end-address register
$440261cc constant RISAF_RISAF_REG7_CIDCFGR  \ offset: 0x1CC : RISAF region 7 CID configuration register
$440261d0 constant RISAF_RISAF_REG7_ACFGR  \ offset: 0x1D0 : RISAF region 7 subregion A configuration register
$440261d4 constant RISAF_RISAF_REG7_ASTARTR  \ offset: 0x1D4 : RISAF region 7 subregion A start-address register
$440261d8 constant RISAF_RISAF_REG7_AENDR  \ offset: 0x1D8 : RISAF region 7 subregion A end-address register
$440261dc constant RISAF_RISAF_REG7_ANESTR  \ offset: 0x1DC : RISAF region 7 subregion A nested mode register
$440261e0 constant RISAF_RISAF_REG7_BCFGR  \ offset: 0x1E0 : RISAF region 7 subregion B configuration register
$440261e4 constant RISAF_RISAF_REG7_BSTARTR  \ offset: 0x1E4 : RISAF region 7 subregion B start-address register
$440261e8 constant RISAF_RISAF_REG7_BENDR  \ offset: 0x1E8 : RISAF region 7 subregion B end-address register
$440261ec constant RISAF_RISAF_REG7_BNESTR  \ offset: 0x1EC : RISAF region 7 subregion B nested mode register
$44026200 constant RISAF_RISAF_REG8_CFGR  \ offset: 0x200 : RISAF region 8 configuration register
$44026204 constant RISAF_RISAF_REG8_STARTR  \ offset: 0x204 : RISAF region 8 start-address register
$44026208 constant RISAF_RISAF_REG8_ENDR  \ offset: 0x208 : RISAF region 8 end-address register
$4402620c constant RISAF_RISAF_REG8_CIDCFGR  \ offset: 0x20C : RISAF region 8 CID configuration register
$44026210 constant RISAF_RISAF_REG8_ACFGR  \ offset: 0x210 : RISAF region 8 subregion A configuration register
$44026214 constant RISAF_RISAF_REG8_ASTARTR  \ offset: 0x214 : RISAF region 8 subregion A start-address register
$44026218 constant RISAF_RISAF_REG8_AENDR  \ offset: 0x218 : RISAF region 8 subregion A end-address register
$4402621c constant RISAF_RISAF_REG8_ANESTR  \ offset: 0x21C : RISAF region 8 subregion A nested mode register
$44026220 constant RISAF_RISAF_REG8_BCFGR  \ offset: 0x220 : RISAF region 8 subregion B configuration register
$44026224 constant RISAF_RISAF_REG8_BSTARTR  \ offset: 0x224 : RISAF region 8 subregion B start-address register
$44026228 constant RISAF_RISAF_REG8_BENDR  \ offset: 0x228 : RISAF region 8 subregion B end-address register
$4402622c constant RISAF_RISAF_REG8_BNESTR  \ offset: 0x22C : RISAF region 8 subregion B nested mode register
$44026240 constant RISAF_RISAF_REG9_CFGR  \ offset: 0x240 : RISAF region 9 configuration register
$44026244 constant RISAF_RISAF_REG9_STARTR  \ offset: 0x244 : RISAF region 9 start-address register
$44026248 constant RISAF_RISAF_REG9_ENDR  \ offset: 0x248 : RISAF region 9 end-address register
$4402624c constant RISAF_RISAF_REG9_CIDCFGR  \ offset: 0x24C : RISAF region 9 CID configuration register
$44026250 constant RISAF_RISAF_REG9_ACFGR  \ offset: 0x250 : RISAF region 9 subregion A configuration register
$44026254 constant RISAF_RISAF_REG9_ASTARTR  \ offset: 0x254 : RISAF region 9 subregion A start-address register
$44026258 constant RISAF_RISAF_REG9_AENDR  \ offset: 0x258 : RISAF region 9 subregion A end-address register
$4402625c constant RISAF_RISAF_REG9_ANESTR  \ offset: 0x25C : RISAF region 9 subregion A nested mode register
$44026260 constant RISAF_RISAF_REG9_BCFGR  \ offset: 0x260 : RISAF region 9 subregion B configuration register
$44026264 constant RISAF_RISAF_REG9_BSTARTR  \ offset: 0x264 : RISAF region 9 subregion B start-address register
$44026268 constant RISAF_RISAF_REG9_BENDR  \ offset: 0x268 : RISAF region 9 subregion B end-address register
$4402626c constant RISAF_RISAF_REG9_BNESTR  \ offset: 0x26C : RISAF region 9 subregion B nested mode register
$44026280 constant RISAF_RISAF_REG10_CFGR  \ offset: 0x280 : RISAF region 10 configuration register
$44026284 constant RISAF_RISAF_REG10_STARTR  \ offset: 0x284 : RISAF region 10 start-address register
$44026288 constant RISAF_RISAF_REG10_ENDR  \ offset: 0x288 : RISAF region 10 end-address register
$4402628c constant RISAF_RISAF_REG10_CIDCFGR  \ offset: 0x28C : RISAF region 10 CID configuration register
$44026290 constant RISAF_RISAF_REG10_ACFGR  \ offset: 0x290 : RISAF region 10 subregion A configuration register
$44026294 constant RISAF_RISAF_REG10_ASTARTR  \ offset: 0x294 : RISAF region 10 subregion A start-address register
$44026298 constant RISAF_RISAF_REG10_AENDR  \ offset: 0x298 : RISAF region 10 subregion A end-address register
$4402629c constant RISAF_RISAF_REG10_ANESTR  \ offset: 0x29C : RISAF region 10 subregion A nested mode register
$440262a0 constant RISAF_RISAF_REG10_BCFGR  \ offset: 0x2A0 : RISAF region 10 subregion B configuration register
$440262a4 constant RISAF_RISAF_REG10_BSTARTR  \ offset: 0x2A4 : RISAF region 10 subregion B start-address register
$440262a8 constant RISAF_RISAF_REG10_BENDR  \ offset: 0x2A8 : RISAF region 10 subregion B end-address register
$440262ac constant RISAF_RISAF_REG10_BNESTR  \ offset: 0x2AC : RISAF region 10 subregion B nested mode register
$440262c0 constant RISAF_RISAF_REG11_CFGR  \ offset: 0x2C0 : RISAF region 11 configuration register
$440262c4 constant RISAF_RISAF_REG11_STARTR  \ offset: 0x2C4 : RISAF region 11 start-address register
$440262c8 constant RISAF_RISAF_REG11_ENDR  \ offset: 0x2C8 : RISAF region 11 end-address register
$440262cc constant RISAF_RISAF_REG11_CIDCFGR  \ offset: 0x2CC : RISAF region 11 CID configuration register
$440262d0 constant RISAF_RISAF_REG11_ACFGR  \ offset: 0x2D0 : RISAF region 11 subregion A configuration register
$440262d4 constant RISAF_RISAF_REG11_ASTARTR  \ offset: 0x2D4 : RISAF region 11 subregion A start-address register
$440262d8 constant RISAF_RISAF_REG11_AENDR  \ offset: 0x2D8 : RISAF region 11 subregion A end-address register
$440262dc constant RISAF_RISAF_REG11_ANESTR  \ offset: 0x2DC : RISAF region 11 subregion A nested mode register
$440262e0 constant RISAF_RISAF_REG11_BCFGR  \ offset: 0x2E0 : RISAF region 11 subregion B configuration register
$440262e4 constant RISAF_RISAF_REG11_BSTARTR  \ offset: 0x2E4 : RISAF region 11 subregion B start-address register
$440262e8 constant RISAF_RISAF_REG11_BENDR  \ offset: 0x2E8 : RISAF region 11 subregion B end-address register
$440262ec constant RISAF_RISAF_REG11_BNESTR  \ offset: 0x2EC : RISAF region 11 subregion B nested mode register
$44026300 constant RISAF_RISAF_REG12_CFGR  \ offset: 0x300 : RISAF region 12 configuration register
$44026304 constant RISAF_RISAF_REG12_STARTR  \ offset: 0x304 : RISAF region 12 start-address register
$44026308 constant RISAF_RISAF_REG12_ENDR  \ offset: 0x308 : RISAF region 12 end-address register
$4402630c constant RISAF_RISAF_REG12_CIDCFGR  \ offset: 0x30C : RISAF region 12 CID configuration register
$44026310 constant RISAF_RISAF_REG12_ACFGR  \ offset: 0x310 : RISAF region 12 subregion A configuration register
$44026314 constant RISAF_RISAF_REG12_ASTARTR  \ offset: 0x314 : RISAF region 12 subregion A start-address register
$44026318 constant RISAF_RISAF_REG12_AENDR  \ offset: 0x318 : RISAF region 12 subregion A end-address register
$4402631c constant RISAF_RISAF_REG12_ANESTR  \ offset: 0x31C : RISAF region 12 subregion A nested mode register
$44026320 constant RISAF_RISAF_REG12_BCFGR  \ offset: 0x320 : RISAF region 12 subregion B configuration register
$44026324 constant RISAF_RISAF_REG12_BSTARTR  \ offset: 0x324 : RISAF region 12 subregion B start-address register
$44026328 constant RISAF_RISAF_REG12_BENDR  \ offset: 0x328 : RISAF region 12 subregion B end-address register
$4402632c constant RISAF_RISAF_REG12_BNESTR  \ offset: 0x32C : RISAF region 12 subregion B nested mode register
$44026340 constant RISAF_RISAF_REG13_CFGR  \ offset: 0x340 : RISAF region 13 configuration register
$44026344 constant RISAF_RISAF_REG13_STARTR  \ offset: 0x344 : RISAF region 13 start-address register
$44026348 constant RISAF_RISAF_REG13_ENDR  \ offset: 0x348 : RISAF region 13 end-address register
$4402634c constant RISAF_RISAF_REG13_CIDCFGR  \ offset: 0x34C : RISAF region 13 CID configuration register
$44026350 constant RISAF_RISAF_REG13_ACFGR  \ offset: 0x350 : RISAF region 13 subregion A configuration register
$44026354 constant RISAF_RISAF_REG13_ASTARTR  \ offset: 0x354 : RISAF region 13 subregion A start-address register
$44026358 constant RISAF_RISAF_REG13_AENDR  \ offset: 0x358 : RISAF region 13 subregion A end-address register
$4402635c constant RISAF_RISAF_REG13_ANESTR  \ offset: 0x35C : RISAF region 13 subregion A nested mode register
$44026360 constant RISAF_RISAF_REG13_BCFGR  \ offset: 0x360 : RISAF region 13 subregion B configuration register
$44026364 constant RISAF_RISAF_REG13_BSTARTR  \ offset: 0x364 : RISAF region 13 subregion B start-address register
$44026368 constant RISAF_RISAF_REG13_BENDR  \ offset: 0x368 : RISAF region 13 subregion B end-address register
$4402636c constant RISAF_RISAF_REG13_BNESTR  \ offset: 0x36C : RISAF region 13 subregion B nested mode register
$44026380 constant RISAF_RISAF_REG14_CFGR  \ offset: 0x380 : RISAF region 14 configuration register
$44026384 constant RISAF_RISAF_REG14_STARTR  \ offset: 0x384 : RISAF region 14 start-address register
$44026388 constant RISAF_RISAF_REG14_ENDR  \ offset: 0x388 : RISAF region 14 end-address register
$4402638c constant RISAF_RISAF_REG14_CIDCFGR  \ offset: 0x38C : RISAF region 14 CID configuration register
$44026390 constant RISAF_RISAF_REG14_ACFGR  \ offset: 0x390 : RISAF region 14 subregion A configuration register
$44026394 constant RISAF_RISAF_REG14_ASTARTR  \ offset: 0x394 : RISAF region 14 subregion A start-address register
$44026398 constant RISAF_RISAF_REG14_AENDR  \ offset: 0x398 : RISAF region 14 subregion A end-address register
$4402639c constant RISAF_RISAF_REG14_ANESTR  \ offset: 0x39C : RISAF region 14 subregion A nested mode register
$440263a0 constant RISAF_RISAF_REG14_BCFGR  \ offset: 0x3A0 : RISAF region 14 subregion B configuration register
$440263a4 constant RISAF_RISAF_REG14_BSTARTR  \ offset: 0x3A4 : RISAF region 14 subregion B start-address register
$440263a8 constant RISAF_RISAF_REG14_BENDR  \ offset: 0x3A8 : RISAF region 14 subregion B end-address register
$440263ac constant RISAF_RISAF_REG14_BNESTR  \ offset: 0x3AC : RISAF region 14 subregion B nested mode register
$440263c0 constant RISAF_RISAF_REG15_CFGR  \ offset: 0x3C0 : RISAF region 15 configuration register
$440263c4 constant RISAF_RISAF_REG15_STARTR  \ offset: 0x3C4 : RISAF region 15 start-address register
$440263c8 constant RISAF_RISAF_REG15_ENDR  \ offset: 0x3C8 : RISAF region 15 end-address register
$440263cc constant RISAF_RISAF_REG15_CIDCFGR  \ offset: 0x3CC : RISAF region 15 CID configuration register
$440263d0 constant RISAF_RISAF_REG15_ACFGR  \ offset: 0x3D0 : RISAF region 15 subregion A configuration register
$440263d4 constant RISAF_RISAF_REG15_ASTARTR  \ offset: 0x3D4 : RISAF region 15 subregion A start-address register
$440263d8 constant RISAF_RISAF_REG15_AENDR  \ offset: 0x3D8 : RISAF region 15 subregion A end-address register
$440263dc constant RISAF_RISAF_REG15_ANESTR  \ offset: 0x3DC : RISAF region 15 subregion A nested mode register
$440263e0 constant RISAF_RISAF_REG15_BCFGR  \ offset: 0x3E0 : RISAF region 15 subregion B configuration register
$440263e4 constant RISAF_RISAF_REG15_BSTARTR  \ offset: 0x3E4 : RISAF region 15 subregion B start-address register
$440263e8 constant RISAF_RISAF_REG15_BENDR  \ offset: 0x3E8 : RISAF region 15 subregion B end-address register
$440263ec constant RISAF_RISAF_REG15_BNESTR  \ offset: 0x3EC : RISAF region 15 subregion B nested mode register

