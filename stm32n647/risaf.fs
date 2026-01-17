\
\ @file risaf.fs
\ @brief Resource isolation slave unit for address space protection
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RISAF_DEF

  [ifdef] RISAF_RISAF_CR_DEF
    \
    \ @brief RISAF configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_GLOCK                    \ [0x00] global lock
  [then]


  [ifdef] RISAF_RISAF_IASR_DEF
    \
    \ @brief RISAF illegal access status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_CAEF                     \ [0x00] configuration access error flag
    $01 constant RISAF_IAEF                     \ [0x01] illegal access error flag
  [then]


  [ifdef] RISAF_RISAF_IACR_DEF
    \
    \ @brief RISAF illegal access clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_CAEF                     \ [0x00] configuration access error flag
    $01 constant RISAF_IAEF                     \ [0x01] illegal access error flag
  [then]


  [ifdef] RISAF_RISAF_IAESR_DEF
    \
    \ @brief RISAF illegal access error status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_IACID                    \ [0x00 : 3] illegal access compartment ID
    $04 constant RISAF_IAPRIV                   \ [0x04] illegal access privileged
    $05 constant RISAF_IASEC                    \ [0x05] illegal access security
    $07 constant RISAF_IANRW                    \ [0x07] illegal access read/write
  [then]


  [ifdef] RISAF_RISAF_IADDR_DEF
    \
    \ @brief RISAF illegal address register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_IADD                     \ [0x00 : 32] illegal address
  [then]


  [ifdef] RISAF_RISAF_REG1_CFGR_DEF
    \
    \ @brief RISAF region 1 configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG1_STARTR_DEF
    \
    \ @brief RISAF region 1 start-address register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG1_ENDR_DEF
    \
    \ @brief RISAF region 1 end-address register
    \ Address offset: 0x48
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG1_CIDCFGR_DEF
    \
    \ @brief RISAF region 1 CID configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG1_ACFGR_DEF
    \
    \ @brief RISAF region 1 subregion A configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG1_ASTARTR_DEF
    \
    \ @brief RISAF region 1 subregion A start-address register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG1_AENDR_DEF
    \
    \ @brief RISAF region 1 subregion A end-address register
    \ Address offset: 0x58
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG1_ANESTR_DEF
    \
    \ @brief RISAF region 1 subregion A nested mode register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG1_BCFGR_DEF
    \
    \ @brief RISAF region 1 subregion B configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG1_BSTARTR_DEF
    \
    \ @brief RISAF region 1 subregion B start-address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG1_BENDR_DEF
    \
    \ @brief RISAF region 1 subregion B end-address register
    \ Address offset: 0x68
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG1_BNESTR_DEF
    \
    \ @brief RISAF region 1 subregion B nested mode register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG2_CFGR_DEF
    \
    \ @brief RISAF region 2 configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG2_STARTR_DEF
    \
    \ @brief RISAF region 2 start-address register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG2_ENDR_DEF
    \
    \ @brief RISAF region 2 end-address register
    \ Address offset: 0x88
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG2_CIDCFGR_DEF
    \
    \ @brief RISAF region 2 CID configuration register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG2_ACFGR_DEF
    \
    \ @brief RISAF region 2 subregion A configuration register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG2_ASTARTR_DEF
    \
    \ @brief RISAF region 2 subregion A start-address register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG2_AENDR_DEF
    \
    \ @brief RISAF region 2 subregion A end-address register
    \ Address offset: 0x98
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG2_ANESTR_DEF
    \
    \ @brief RISAF region 2 subregion A nested mode register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG2_BCFGR_DEF
    \
    \ @brief RISAF region 2 subregion B configuration register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG2_BSTARTR_DEF
    \
    \ @brief RISAF region 2 subregion B start-address register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG2_BENDR_DEF
    \
    \ @brief RISAF region 2 subregion B end-address register
    \ Address offset: 0xA8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG2_BNESTR_DEF
    \
    \ @brief RISAF region 2 subregion B nested mode register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG3_CFGR_DEF
    \
    \ @brief RISAF region 3 configuration register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG3_STARTR_DEF
    \
    \ @brief RISAF region 3 start-address register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG3_ENDR_DEF
    \
    \ @brief RISAF region 3 end-address register
    \ Address offset: 0xC8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG3_CIDCFGR_DEF
    \
    \ @brief RISAF region 3 CID configuration register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG3_ACFGR_DEF
    \
    \ @brief RISAF region 3 subregion A configuration register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG3_ASTARTR_DEF
    \
    \ @brief RISAF region 3 subregion A start-address register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG3_AENDR_DEF
    \
    \ @brief RISAF region 3 subregion A end-address register
    \ Address offset: 0xD8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG3_ANESTR_DEF
    \
    \ @brief RISAF region 3 subregion A nested mode register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG3_BCFGR_DEF
    \
    \ @brief RISAF region 3 subregion B configuration register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG3_BSTARTR_DEF
    \
    \ @brief RISAF region 3 subregion B start-address register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG3_BENDR_DEF
    \
    \ @brief RISAF region 3 subregion B end-address register
    \ Address offset: 0xE8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG3_BNESTR_DEF
    \
    \ @brief RISAF region 3 subregion B nested mode register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG4_CFGR_DEF
    \
    \ @brief RISAF region 4 configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG4_STARTR_DEF
    \
    \ @brief RISAF region 4 start-address register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG4_ENDR_DEF
    \
    \ @brief RISAF region 4 end-address register
    \ Address offset: 0x108
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG4_CIDCFGR_DEF
    \
    \ @brief RISAF region 4 CID configuration register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG4_ACFGR_DEF
    \
    \ @brief RISAF region 4 subregion A configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG4_ASTARTR_DEF
    \
    \ @brief RISAF region 4 subregion A start-address register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG4_AENDR_DEF
    \
    \ @brief RISAF region 4 subregion A end-address register
    \ Address offset: 0x118
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG4_ANESTR_DEF
    \
    \ @brief RISAF region 4 subregion A nested mode register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG4_BCFGR_DEF
    \
    \ @brief RISAF region 4 subregion B configuration register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG4_BSTARTR_DEF
    \
    \ @brief RISAF region 4 subregion B start-address register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG4_BENDR_DEF
    \
    \ @brief RISAF region 4 subregion B end-address register
    \ Address offset: 0x128
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG4_BNESTR_DEF
    \
    \ @brief RISAF region 4 subregion B nested mode register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG5_CFGR_DEF
    \
    \ @brief RISAF region 5 configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG5_STARTR_DEF
    \
    \ @brief RISAF region 5 start-address register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG5_ENDR_DEF
    \
    \ @brief RISAF region 5 end-address register
    \ Address offset: 0x148
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG5_CIDCFGR_DEF
    \
    \ @brief RISAF region 5 CID configuration register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG5_ACFGR_DEF
    \
    \ @brief RISAF region 5 subregion A configuration register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG5_ASTARTR_DEF
    \
    \ @brief RISAF region 5 subregion A start-address register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG5_AENDR_DEF
    \
    \ @brief RISAF region 5 subregion A end-address register
    \ Address offset: 0x158
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG5_ANESTR_DEF
    \
    \ @brief RISAF region 5 subregion A nested mode register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG5_BCFGR_DEF
    \
    \ @brief RISAF region 5 subregion B configuration register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG5_BSTARTR_DEF
    \
    \ @brief RISAF region 5 subregion B start-address register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG5_BENDR_DEF
    \
    \ @brief RISAF region 5 subregion B end-address register
    \ Address offset: 0x168
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG5_BNESTR_DEF
    \
    \ @brief RISAF region 5 subregion B nested mode register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG6_CFGR_DEF
    \
    \ @brief RISAF region 6 configuration register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG6_STARTR_DEF
    \
    \ @brief RISAF region 6 start-address register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG6_ENDR_DEF
    \
    \ @brief RISAF region 6 end-address register
    \ Address offset: 0x188
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG6_CIDCFGR_DEF
    \
    \ @brief RISAF region 6 CID configuration register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG6_ACFGR_DEF
    \
    \ @brief RISAF region 6 subregion A configuration register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG6_ASTARTR_DEF
    \
    \ @brief RISAF region 6 subregion A start-address register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG6_AENDR_DEF
    \
    \ @brief RISAF region 6 subregion A end-address register
    \ Address offset: 0x198
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG6_ANESTR_DEF
    \
    \ @brief RISAF region 6 subregion A nested mode register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG6_BCFGR_DEF
    \
    \ @brief RISAF region 6 subregion B configuration register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG6_BSTARTR_DEF
    \
    \ @brief RISAF region 6 subregion B start-address register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG6_BENDR_DEF
    \
    \ @brief RISAF region 6 subregion B end-address register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG6_BNESTR_DEF
    \
    \ @brief RISAF region 6 subregion B nested mode register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG7_CFGR_DEF
    \
    \ @brief RISAF region 7 configuration register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG7_STARTR_DEF
    \
    \ @brief RISAF region 7 start-address register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG7_ENDR_DEF
    \
    \ @brief RISAF region 7 end-address register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG7_CIDCFGR_DEF
    \
    \ @brief RISAF region 7 CID configuration register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG7_ACFGR_DEF
    \
    \ @brief RISAF region 7 subregion A configuration register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG7_ASTARTR_DEF
    \
    \ @brief RISAF region 7 subregion A start-address register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG7_AENDR_DEF
    \
    \ @brief RISAF region 7 subregion A end-address register
    \ Address offset: 0x1D8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG7_ANESTR_DEF
    \
    \ @brief RISAF region 7 subregion A nested mode register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG7_BCFGR_DEF
    \
    \ @brief RISAF region 7 subregion B configuration register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG7_BSTARTR_DEF
    \
    \ @brief RISAF region 7 subregion B start-address register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG7_BENDR_DEF
    \
    \ @brief RISAF region 7 subregion B end-address register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG7_BNESTR_DEF
    \
    \ @brief RISAF region 7 subregion B nested mode register
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG8_CFGR_DEF
    \
    \ @brief RISAF region 8 configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG8_STARTR_DEF
    \
    \ @brief RISAF region 8 start-address register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG8_ENDR_DEF
    \
    \ @brief RISAF region 8 end-address register
    \ Address offset: 0x208
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG8_CIDCFGR_DEF
    \
    \ @brief RISAF region 8 CID configuration register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG8_ACFGR_DEF
    \
    \ @brief RISAF region 8 subregion A configuration register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG8_ASTARTR_DEF
    \
    \ @brief RISAF region 8 subregion A start-address register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG8_AENDR_DEF
    \
    \ @brief RISAF region 8 subregion A end-address register
    \ Address offset: 0x218
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG8_ANESTR_DEF
    \
    \ @brief RISAF region 8 subregion A nested mode register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG8_BCFGR_DEF
    \
    \ @brief RISAF region 8 subregion B configuration register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG8_BSTARTR_DEF
    \
    \ @brief RISAF region 8 subregion B start-address register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG8_BENDR_DEF
    \
    \ @brief RISAF region 8 subregion B end-address register
    \ Address offset: 0x228
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG8_BNESTR_DEF
    \
    \ @brief RISAF region 8 subregion B nested mode register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG9_CFGR_DEF
    \
    \ @brief RISAF region 9 configuration register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG9_STARTR_DEF
    \
    \ @brief RISAF region 9 start-address register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG9_ENDR_DEF
    \
    \ @brief RISAF region 9 end-address register
    \ Address offset: 0x248
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG9_CIDCFGR_DEF
    \
    \ @brief RISAF region 9 CID configuration register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG9_ACFGR_DEF
    \
    \ @brief RISAF region 9 subregion A configuration register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG9_ASTARTR_DEF
    \
    \ @brief RISAF region 9 subregion A start-address register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG9_AENDR_DEF
    \
    \ @brief RISAF region 9 subregion A end-address register
    \ Address offset: 0x258
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG9_ANESTR_DEF
    \
    \ @brief RISAF region 9 subregion A nested mode register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG9_BCFGR_DEF
    \
    \ @brief RISAF region 9 subregion B configuration register
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG9_BSTARTR_DEF
    \
    \ @brief RISAF region 9 subregion B start-address register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG9_BENDR_DEF
    \
    \ @brief RISAF region 9 subregion B end-address register
    \ Address offset: 0x268
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG9_BNESTR_DEF
    \
    \ @brief RISAF region 9 subregion B nested mode register
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG10_CFGR_DEF
    \
    \ @brief RISAF region 10 configuration register
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG10_STARTR_DEF
    \
    \ @brief RISAF region 10 start-address register
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG10_ENDR_DEF
    \
    \ @brief RISAF region 10 end-address register
    \ Address offset: 0x288
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG10_CIDCFGR_DEF
    \
    \ @brief RISAF region 10 CID configuration register
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG10_ACFGR_DEF
    \
    \ @brief RISAF region 10 subregion A configuration register
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG10_ASTARTR_DEF
    \
    \ @brief RISAF region 10 subregion A start-address register
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG10_AENDR_DEF
    \
    \ @brief RISAF region 10 subregion A end-address register
    \ Address offset: 0x298
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG10_ANESTR_DEF
    \
    \ @brief RISAF region 10 subregion A nested mode register
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG10_BCFGR_DEF
    \
    \ @brief RISAF region 10 subregion B configuration register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG10_BSTARTR_DEF
    \
    \ @brief RISAF region 10 subregion B start-address register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG10_BENDR_DEF
    \
    \ @brief RISAF region 10 subregion B end-address register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG10_BNESTR_DEF
    \
    \ @brief RISAF region 10 subregion B nested mode register
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG11_CFGR_DEF
    \
    \ @brief RISAF region 11 configuration register
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG11_STARTR_DEF
    \
    \ @brief RISAF region 11 start-address register
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG11_ENDR_DEF
    \
    \ @brief RISAF region 11 end-address register
    \ Address offset: 0x2C8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG11_CIDCFGR_DEF
    \
    \ @brief RISAF region 11 CID configuration register
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG11_ACFGR_DEF
    \
    \ @brief RISAF region 11 subregion A configuration register
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG11_ASTARTR_DEF
    \
    \ @brief RISAF region 11 subregion A start-address register
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG11_AENDR_DEF
    \
    \ @brief RISAF region 11 subregion A end-address register
    \ Address offset: 0x2D8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG11_ANESTR_DEF
    \
    \ @brief RISAF region 11 subregion A nested mode register
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG11_BCFGR_DEF
    \
    \ @brief RISAF region 11 subregion B configuration register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG11_BSTARTR_DEF
    \
    \ @brief RISAF region 11 subregion B start-address register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG11_BENDR_DEF
    \
    \ @brief RISAF region 11 subregion B end-address register
    \ Address offset: 0x2E8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG11_BNESTR_DEF
    \
    \ @brief RISAF region 11 subregion B nested mode register
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG12_CFGR_DEF
    \
    \ @brief RISAF region 12 configuration register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG12_STARTR_DEF
    \
    \ @brief RISAF region 12 start-address register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG12_ENDR_DEF
    \
    \ @brief RISAF region 12 end-address register
    \ Address offset: 0x308
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG12_CIDCFGR_DEF
    \
    \ @brief RISAF region 12 CID configuration register
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG12_ACFGR_DEF
    \
    \ @brief RISAF region 12 subregion A configuration register
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG12_ASTARTR_DEF
    \
    \ @brief RISAF region 12 subregion A start-address register
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG12_AENDR_DEF
    \
    \ @brief RISAF region 12 subregion A end-address register
    \ Address offset: 0x318
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG12_ANESTR_DEF
    \
    \ @brief RISAF region 12 subregion A nested mode register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG12_BCFGR_DEF
    \
    \ @brief RISAF region 12 subregion B configuration register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG12_BSTARTR_DEF
    \
    \ @brief RISAF region 12 subregion B start-address register
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG12_BENDR_DEF
    \
    \ @brief RISAF region 12 subregion B end-address register
    \ Address offset: 0x328
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG12_BNESTR_DEF
    \
    \ @brief RISAF region 12 subregion B nested mode register
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG13_CFGR_DEF
    \
    \ @brief RISAF region 13 configuration register
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG13_STARTR_DEF
    \
    \ @brief RISAF region 13 start-address register
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG13_ENDR_DEF
    \
    \ @brief RISAF region 13 end-address register
    \ Address offset: 0x348
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG13_CIDCFGR_DEF
    \
    \ @brief RISAF region 13 CID configuration register
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG13_ACFGR_DEF
    \
    \ @brief RISAF region 13 subregion A configuration register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG13_ASTARTR_DEF
    \
    \ @brief RISAF region 13 subregion A start-address register
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG13_AENDR_DEF
    \
    \ @brief RISAF region 13 subregion A end-address register
    \ Address offset: 0x358
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG13_ANESTR_DEF
    \
    \ @brief RISAF region 13 subregion A nested mode register
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG13_BCFGR_DEF
    \
    \ @brief RISAF region 13 subregion B configuration register
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG13_BSTARTR_DEF
    \
    \ @brief RISAF region 13 subregion B start-address register
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG13_BENDR_DEF
    \
    \ @brief RISAF region 13 subregion B end-address register
    \ Address offset: 0x368
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG13_BNESTR_DEF
    \
    \ @brief RISAF region 13 subregion B nested mode register
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG14_CFGR_DEF
    \
    \ @brief RISAF region 14 configuration register
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG14_STARTR_DEF
    \
    \ @brief RISAF region 14 start-address register
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG14_ENDR_DEF
    \
    \ @brief RISAF region 14 end-address register
    \ Address offset: 0x388
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG14_CIDCFGR_DEF
    \
    \ @brief RISAF region 14 CID configuration register
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG14_ACFGR_DEF
    \
    \ @brief RISAF region 14 subregion A configuration register
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG14_ASTARTR_DEF
    \
    \ @brief RISAF region 14 subregion A start-address register
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG14_AENDR_DEF
    \
    \ @brief RISAF region 14 subregion A end-address register
    \ Address offset: 0x398
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG14_ANESTR_DEF
    \
    \ @brief RISAF region 14 subregion A nested mode register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG14_BCFGR_DEF
    \
    \ @brief RISAF region 14 subregion B configuration register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG14_BSTARTR_DEF
    \
    \ @brief RISAF region 14 subregion B start-address register
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG14_BENDR_DEF
    \
    \ @brief RISAF region 14 subregion B end-address register
    \ Address offset: 0x3A8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG14_BNESTR_DEF
    \
    \ @brief RISAF region 14 subregion B nested mode register
    \ Address offset: 0x3AC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG15_CFGR_DEF
    \
    \ @brief RISAF region 15 configuration register
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BREN                     \ [0x00] base region enable
    $08 constant RISAF_SEC                      \ [0x08] secure region
    $10 constant RISAF_PRIVC0                   \ [0x10] privileged access for compartment y
    $11 constant RISAF_PRIVC1                   \ [0x11] privileged access for compartment y
    $12 constant RISAF_PRIVC2                   \ [0x12] privileged access for compartment y
    $13 constant RISAF_PRIVC3                   \ [0x13] privileged access for compartment y
    $14 constant RISAF_PRIVC4                   \ [0x14] privileged access for compartment y
    $15 constant RISAF_PRIVC5                   \ [0x15] privileged access for compartment y
    $16 constant RISAF_PRIVC6                   \ [0x16] privileged access for compartment y
    $17 constant RISAF_PRIVC7                   \ [0x17] privileged access for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG15_STARTR_DEF
    \
    \ @brief RISAF region 15 start-address register
    \ Address offset: 0x3C4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_BADDSTART                \ [0x00 : 32] Base region address start
  [then]


  [ifdef] RISAF_RISAF_REG15_ENDR_DEF
    \
    \ @brief RISAF region 15 end-address register
    \ Address offset: 0x3C8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_BADDEND                  \ [0x00 : 32] Base region address end
  [then]


  [ifdef] RISAF_RISAF_REG15_CIDCFGR_DEF
    \
    \ @brief RISAF region 15 CID configuration register
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_RDENC0                   \ [0x00] read enable for compartment y
    $01 constant RISAF_RDENC1                   \ [0x01] read enable for compartment y
    $02 constant RISAF_RDENC2                   \ [0x02] read enable for compartment y
    $03 constant RISAF_RDENC3                   \ [0x03] read enable for compartment y
    $04 constant RISAF_RDENC4                   \ [0x04] read enable for compartment y
    $05 constant RISAF_RDENC5                   \ [0x05] read enable for compartment y
    $06 constant RISAF_RDENC6                   \ [0x06] read enable for compartment y
    $07 constant RISAF_RDENC7                   \ [0x07] read enable for compartment y
    $10 constant RISAF_WRENC0                   \ [0x10] write enable for compartment y
    $11 constant RISAF_WRENC1                   \ [0x11] write enable for compartment y
    $12 constant RISAF_WRENC2                   \ [0x12] write enable for compartment y
    $13 constant RISAF_WRENC3                   \ [0x13] write enable for compartment y
    $14 constant RISAF_WRENC4                   \ [0x14] write enable for compartment y
    $15 constant RISAF_WRENC5                   \ [0x15] write enable for compartment y
    $16 constant RISAF_WRENC6                   \ [0x16] write enable for compartment y
    $17 constant RISAF_WRENC7                   \ [0x17] write enable for compartment y
  [then]


  [ifdef] RISAF_RISAF_REG15_ACFGR_DEF
    \
    \ @brief RISAF region 15 subregion A configuration register
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG15_ASTARTR_DEF
    \
    \ @brief RISAF region 15 subregion A start-address register
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG15_AENDR_DEF
    \
    \ @brief RISAF region 15 subregion A end-address register
    \ Address offset: 0x3D8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG15_ANESTR_DEF
    \
    \ @brief RISAF region 15 subregion A nested mode register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]


  [ifdef] RISAF_RISAF_REG15_BCFGR_DEF
    \
    \ @brief RISAF region 15 subregion B configuration register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SREN                     \ [0x00] subregion enable
    $01 constant RISAF_RLOCK                    \ [0x01] resource lock
    $04 constant RISAF_SRCID                    \ [0x04 : 3] subregion CID
    $08 constant RISAF_SEC                      \ [0x08] secure subregion
    $09 constant RISAF_PRIV                     \ [0x09] privileged subregion
    $0c constant RISAF_RDEN                     \ [0x0c] read enable
    $0d constant RISAF_WREN                     \ [0x0d] write enable
  [then]


  [ifdef] RISAF_RISAF_REG15_BSTARTR_DEF
    \
    \ @brief RISAF region 15 subregion B start-address register
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant RISAF_SADDSTART                \ [0x00 : 32] subregion address start
  [then]


  [ifdef] RISAF_RISAF_REG15_BENDR_DEF
    \
    \ @brief RISAF region 15 subregion B end-address register
    \ Address offset: 0x3E8
    \ Reset value: 0x00000FFF
    \
    $00 constant RISAF_SADDEND                  \ [0x00 : 32] subregion address end
  [then]


  [ifdef] RISAF_RISAF_REG15_BNESTR_DEF
    \
    \ @brief RISAF region 15 subregion B nested mode register
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $02 constant RISAF_DCEN                     \ [0x02] delegated configuration enable
  [then]

  \
  \ @brief Resource isolation slave unit for address space protection
  \
  $00 constant RISAF_RISAF_CR           \ RISAF configuration register
  $08 constant RISAF_RISAF_IASR         \ RISAF illegal access status register
  $0C constant RISAF_RISAF_IACR         \ RISAF illegal access clear register
  $20 constant RISAF_RISAF_IAESR        \ RISAF illegal access error status register
  $24 constant RISAF_RISAF_IADDR        \ RISAF illegal address register
  $40 constant RISAF_RISAF_REG1_CFGR    \ RISAF region 1 configuration register
  $44 constant RISAF_RISAF_REG1_STARTR  \ RISAF region 1 start-address register
  $48 constant RISAF_RISAF_REG1_ENDR    \ RISAF region 1 end-address register
  $4C constant RISAF_RISAF_REG1_CIDCFGR \ RISAF region 1 CID configuration register
  $50 constant RISAF_RISAF_REG1_ACFGR   \ RISAF region 1 subregion A configuration register
  $54 constant RISAF_RISAF_REG1_ASTARTR \ RISAF region 1 subregion A start-address register
  $58 constant RISAF_RISAF_REG1_AENDR   \ RISAF region 1 subregion A end-address register
  $5C constant RISAF_RISAF_REG1_ANESTR  \ RISAF region 1 subregion A nested mode register
  $60 constant RISAF_RISAF_REG1_BCFGR   \ RISAF region 1 subregion B configuration register
  $64 constant RISAF_RISAF_REG1_BSTARTR \ RISAF region 1 subregion B start-address register
  $68 constant RISAF_RISAF_REG1_BENDR   \ RISAF region 1 subregion B end-address register
  $6C constant RISAF_RISAF_REG1_BNESTR  \ RISAF region 1 subregion B nested mode register
  $80 constant RISAF_RISAF_REG2_CFGR    \ RISAF region 2 configuration register
  $84 constant RISAF_RISAF_REG2_STARTR  \ RISAF region 2 start-address register
  $88 constant RISAF_RISAF_REG2_ENDR    \ RISAF region 2 end-address register
  $8C constant RISAF_RISAF_REG2_CIDCFGR \ RISAF region 2 CID configuration register
  $90 constant RISAF_RISAF_REG2_ACFGR   \ RISAF region 2 subregion A configuration register
  $94 constant RISAF_RISAF_REG2_ASTARTR \ RISAF region 2 subregion A start-address register
  $98 constant RISAF_RISAF_REG2_AENDR   \ RISAF region 2 subregion A end-address register
  $9C constant RISAF_RISAF_REG2_ANESTR  \ RISAF region 2 subregion A nested mode register
  $A0 constant RISAF_RISAF_REG2_BCFGR   \ RISAF region 2 subregion B configuration register
  $A4 constant RISAF_RISAF_REG2_BSTARTR \ RISAF region 2 subregion B start-address register
  $A8 constant RISAF_RISAF_REG2_BENDR   \ RISAF region 2 subregion B end-address register
  $AC constant RISAF_RISAF_REG2_BNESTR  \ RISAF region 2 subregion B nested mode register
  $C0 constant RISAF_RISAF_REG3_CFGR    \ RISAF region 3 configuration register
  $C4 constant RISAF_RISAF_REG3_STARTR  \ RISAF region 3 start-address register
  $C8 constant RISAF_RISAF_REG3_ENDR    \ RISAF region 3 end-address register
  $CC constant RISAF_RISAF_REG3_CIDCFGR \ RISAF region 3 CID configuration register
  $D0 constant RISAF_RISAF_REG3_ACFGR   \ RISAF region 3 subregion A configuration register
  $D4 constant RISAF_RISAF_REG3_ASTARTR \ RISAF region 3 subregion A start-address register
  $D8 constant RISAF_RISAF_REG3_AENDR   \ RISAF region 3 subregion A end-address register
  $DC constant RISAF_RISAF_REG3_ANESTR  \ RISAF region 3 subregion A nested mode register
  $E0 constant RISAF_RISAF_REG3_BCFGR   \ RISAF region 3 subregion B configuration register
  $E4 constant RISAF_RISAF_REG3_BSTARTR \ RISAF region 3 subregion B start-address register
  $E8 constant RISAF_RISAF_REG3_BENDR   \ RISAF region 3 subregion B end-address register
  $EC constant RISAF_RISAF_REG3_BNESTR  \ RISAF region 3 subregion B nested mode register
  $100 constant RISAF_RISAF_REG4_CFGR   \ RISAF region 4 configuration register
  $104 constant RISAF_RISAF_REG4_STARTR \ RISAF region 4 start-address register
  $108 constant RISAF_RISAF_REG4_ENDR   \ RISAF region 4 end-address register
  $10C constant RISAF_RISAF_REG4_CIDCFGR    \ RISAF region 4 CID configuration register
  $110 constant RISAF_RISAF_REG4_ACFGR  \ RISAF region 4 subregion A configuration register
  $114 constant RISAF_RISAF_REG4_ASTARTR    \ RISAF region 4 subregion A start-address register
  $118 constant RISAF_RISAF_REG4_AENDR  \ RISAF region 4 subregion A end-address register
  $11C constant RISAF_RISAF_REG4_ANESTR \ RISAF region 4 subregion A nested mode register
  $120 constant RISAF_RISAF_REG4_BCFGR  \ RISAF region 4 subregion B configuration register
  $124 constant RISAF_RISAF_REG4_BSTARTR    \ RISAF region 4 subregion B start-address register
  $128 constant RISAF_RISAF_REG4_BENDR  \ RISAF region 4 subregion B end-address register
  $12C constant RISAF_RISAF_REG4_BNESTR \ RISAF region 4 subregion B nested mode register
  $140 constant RISAF_RISAF_REG5_CFGR   \ RISAF region 5 configuration register
  $144 constant RISAF_RISAF_REG5_STARTR \ RISAF region 5 start-address register
  $148 constant RISAF_RISAF_REG5_ENDR   \ RISAF region 5 end-address register
  $14C constant RISAF_RISAF_REG5_CIDCFGR    \ RISAF region 5 CID configuration register
  $150 constant RISAF_RISAF_REG5_ACFGR  \ RISAF region 5 subregion A configuration register
  $154 constant RISAF_RISAF_REG5_ASTARTR    \ RISAF region 5 subregion A start-address register
  $158 constant RISAF_RISAF_REG5_AENDR  \ RISAF region 5 subregion A end-address register
  $15C constant RISAF_RISAF_REG5_ANESTR \ RISAF region 5 subregion A nested mode register
  $160 constant RISAF_RISAF_REG5_BCFGR  \ RISAF region 5 subregion B configuration register
  $164 constant RISAF_RISAF_REG5_BSTARTR    \ RISAF region 5 subregion B start-address register
  $168 constant RISAF_RISAF_REG5_BENDR  \ RISAF region 5 subregion B end-address register
  $16C constant RISAF_RISAF_REG5_BNESTR \ RISAF region 5 subregion B nested mode register
  $180 constant RISAF_RISAF_REG6_CFGR   \ RISAF region 6 configuration register
  $184 constant RISAF_RISAF_REG6_STARTR \ RISAF region 6 start-address register
  $188 constant RISAF_RISAF_REG6_ENDR   \ RISAF region 6 end-address register
  $18C constant RISAF_RISAF_REG6_CIDCFGR    \ RISAF region 6 CID configuration register
  $190 constant RISAF_RISAF_REG6_ACFGR  \ RISAF region 6 subregion A configuration register
  $194 constant RISAF_RISAF_REG6_ASTARTR    \ RISAF region 6 subregion A start-address register
  $198 constant RISAF_RISAF_REG6_AENDR  \ RISAF region 6 subregion A end-address register
  $19C constant RISAF_RISAF_REG6_ANESTR \ RISAF region 6 subregion A nested mode register
  $1A0 constant RISAF_RISAF_REG6_BCFGR  \ RISAF region 6 subregion B configuration register
  $1A4 constant RISAF_RISAF_REG6_BSTARTR    \ RISAF region 6 subregion B start-address register
  $1A8 constant RISAF_RISAF_REG6_BENDR  \ RISAF region 6 subregion B end-address register
  $1AC constant RISAF_RISAF_REG6_BNESTR \ RISAF region 6 subregion B nested mode register
  $1C0 constant RISAF_RISAF_REG7_CFGR   \ RISAF region 7 configuration register
  $1C4 constant RISAF_RISAF_REG7_STARTR \ RISAF region 7 start-address register
  $1C8 constant RISAF_RISAF_REG7_ENDR   \ RISAF region 7 end-address register
  $1CC constant RISAF_RISAF_REG7_CIDCFGR    \ RISAF region 7 CID configuration register
  $1D0 constant RISAF_RISAF_REG7_ACFGR  \ RISAF region 7 subregion A configuration register
  $1D4 constant RISAF_RISAF_REG7_ASTARTR    \ RISAF region 7 subregion A start-address register
  $1D8 constant RISAF_RISAF_REG7_AENDR  \ RISAF region 7 subregion A end-address register
  $1DC constant RISAF_RISAF_REG7_ANESTR \ RISAF region 7 subregion A nested mode register
  $1E0 constant RISAF_RISAF_REG7_BCFGR  \ RISAF region 7 subregion B configuration register
  $1E4 constant RISAF_RISAF_REG7_BSTARTR    \ RISAF region 7 subregion B start-address register
  $1E8 constant RISAF_RISAF_REG7_BENDR  \ RISAF region 7 subregion B end-address register
  $1EC constant RISAF_RISAF_REG7_BNESTR \ RISAF region 7 subregion B nested mode register
  $200 constant RISAF_RISAF_REG8_CFGR   \ RISAF region 8 configuration register
  $204 constant RISAF_RISAF_REG8_STARTR \ RISAF region 8 start-address register
  $208 constant RISAF_RISAF_REG8_ENDR   \ RISAF region 8 end-address register
  $20C constant RISAF_RISAF_REG8_CIDCFGR    \ RISAF region 8 CID configuration register
  $210 constant RISAF_RISAF_REG8_ACFGR  \ RISAF region 8 subregion A configuration register
  $214 constant RISAF_RISAF_REG8_ASTARTR    \ RISAF region 8 subregion A start-address register
  $218 constant RISAF_RISAF_REG8_AENDR  \ RISAF region 8 subregion A end-address register
  $21C constant RISAF_RISAF_REG8_ANESTR \ RISAF region 8 subregion A nested mode register
  $220 constant RISAF_RISAF_REG8_BCFGR  \ RISAF region 8 subregion B configuration register
  $224 constant RISAF_RISAF_REG8_BSTARTR    \ RISAF region 8 subregion B start-address register
  $228 constant RISAF_RISAF_REG8_BENDR  \ RISAF region 8 subregion B end-address register
  $22C constant RISAF_RISAF_REG8_BNESTR \ RISAF region 8 subregion B nested mode register
  $240 constant RISAF_RISAF_REG9_CFGR   \ RISAF region 9 configuration register
  $244 constant RISAF_RISAF_REG9_STARTR \ RISAF region 9 start-address register
  $248 constant RISAF_RISAF_REG9_ENDR   \ RISAF region 9 end-address register
  $24C constant RISAF_RISAF_REG9_CIDCFGR    \ RISAF region 9 CID configuration register
  $250 constant RISAF_RISAF_REG9_ACFGR  \ RISAF region 9 subregion A configuration register
  $254 constant RISAF_RISAF_REG9_ASTARTR    \ RISAF region 9 subregion A start-address register
  $258 constant RISAF_RISAF_REG9_AENDR  \ RISAF region 9 subregion A end-address register
  $25C constant RISAF_RISAF_REG9_ANESTR \ RISAF region 9 subregion A nested mode register
  $260 constant RISAF_RISAF_REG9_BCFGR  \ RISAF region 9 subregion B configuration register
  $264 constant RISAF_RISAF_REG9_BSTARTR    \ RISAF region 9 subregion B start-address register
  $268 constant RISAF_RISAF_REG9_BENDR  \ RISAF region 9 subregion B end-address register
  $26C constant RISAF_RISAF_REG9_BNESTR \ RISAF region 9 subregion B nested mode register
  $280 constant RISAF_RISAF_REG10_CFGR  \ RISAF region 10 configuration register
  $284 constant RISAF_RISAF_REG10_STARTR    \ RISAF region 10 start-address register
  $288 constant RISAF_RISAF_REG10_ENDR  \ RISAF region 10 end-address register
  $28C constant RISAF_RISAF_REG10_CIDCFGR    \ RISAF region 10 CID configuration register
  $290 constant RISAF_RISAF_REG10_ACFGR \ RISAF region 10 subregion A configuration register
  $294 constant RISAF_RISAF_REG10_ASTARTR    \ RISAF region 10 subregion A start-address register
  $298 constant RISAF_RISAF_REG10_AENDR \ RISAF region 10 subregion A end-address register
  $29C constant RISAF_RISAF_REG10_ANESTR    \ RISAF region 10 subregion A nested mode register
  $2A0 constant RISAF_RISAF_REG10_BCFGR \ RISAF region 10 subregion B configuration register
  $2A4 constant RISAF_RISAF_REG10_BSTARTR    \ RISAF region 10 subregion B start-address register
  $2A8 constant RISAF_RISAF_REG10_BENDR \ RISAF region 10 subregion B end-address register
  $2AC constant RISAF_RISAF_REG10_BNESTR    \ RISAF region 10 subregion B nested mode register
  $2C0 constant RISAF_RISAF_REG11_CFGR  \ RISAF region 11 configuration register
  $2C4 constant RISAF_RISAF_REG11_STARTR    \ RISAF region 11 start-address register
  $2C8 constant RISAF_RISAF_REG11_ENDR  \ RISAF region 11 end-address register
  $2CC constant RISAF_RISAF_REG11_CIDCFGR    \ RISAF region 11 CID configuration register
  $2D0 constant RISAF_RISAF_REG11_ACFGR \ RISAF region 11 subregion A configuration register
  $2D4 constant RISAF_RISAF_REG11_ASTARTR    \ RISAF region 11 subregion A start-address register
  $2D8 constant RISAF_RISAF_REG11_AENDR \ RISAF region 11 subregion A end-address register
  $2DC constant RISAF_RISAF_REG11_ANESTR    \ RISAF region 11 subregion A nested mode register
  $2E0 constant RISAF_RISAF_REG11_BCFGR \ RISAF region 11 subregion B configuration register
  $2E4 constant RISAF_RISAF_REG11_BSTARTR    \ RISAF region 11 subregion B start-address register
  $2E8 constant RISAF_RISAF_REG11_BENDR \ RISAF region 11 subregion B end-address register
  $2EC constant RISAF_RISAF_REG11_BNESTR    \ RISAF region 11 subregion B nested mode register
  $300 constant RISAF_RISAF_REG12_CFGR  \ RISAF region 12 configuration register
  $304 constant RISAF_RISAF_REG12_STARTR    \ RISAF region 12 start-address register
  $308 constant RISAF_RISAF_REG12_ENDR  \ RISAF region 12 end-address register
  $30C constant RISAF_RISAF_REG12_CIDCFGR    \ RISAF region 12 CID configuration register
  $310 constant RISAF_RISAF_REG12_ACFGR \ RISAF region 12 subregion A configuration register
  $314 constant RISAF_RISAF_REG12_ASTARTR    \ RISAF region 12 subregion A start-address register
  $318 constant RISAF_RISAF_REG12_AENDR \ RISAF region 12 subregion A end-address register
  $31C constant RISAF_RISAF_REG12_ANESTR    \ RISAF region 12 subregion A nested mode register
  $320 constant RISAF_RISAF_REG12_BCFGR \ RISAF region 12 subregion B configuration register
  $324 constant RISAF_RISAF_REG12_BSTARTR    \ RISAF region 12 subregion B start-address register
  $328 constant RISAF_RISAF_REG12_BENDR \ RISAF region 12 subregion B end-address register
  $32C constant RISAF_RISAF_REG12_BNESTR    \ RISAF region 12 subregion B nested mode register
  $340 constant RISAF_RISAF_REG13_CFGR  \ RISAF region 13 configuration register
  $344 constant RISAF_RISAF_REG13_STARTR    \ RISAF region 13 start-address register
  $348 constant RISAF_RISAF_REG13_ENDR  \ RISAF region 13 end-address register
  $34C constant RISAF_RISAF_REG13_CIDCFGR    \ RISAF region 13 CID configuration register
  $350 constant RISAF_RISAF_REG13_ACFGR \ RISAF region 13 subregion A configuration register
  $354 constant RISAF_RISAF_REG13_ASTARTR    \ RISAF region 13 subregion A start-address register
  $358 constant RISAF_RISAF_REG13_AENDR \ RISAF region 13 subregion A end-address register
  $35C constant RISAF_RISAF_REG13_ANESTR    \ RISAF region 13 subregion A nested mode register
  $360 constant RISAF_RISAF_REG13_BCFGR \ RISAF region 13 subregion B configuration register
  $364 constant RISAF_RISAF_REG13_BSTARTR    \ RISAF region 13 subregion B start-address register
  $368 constant RISAF_RISAF_REG13_BENDR \ RISAF region 13 subregion B end-address register
  $36C constant RISAF_RISAF_REG13_BNESTR    \ RISAF region 13 subregion B nested mode register
  $380 constant RISAF_RISAF_REG14_CFGR  \ RISAF region 14 configuration register
  $384 constant RISAF_RISAF_REG14_STARTR    \ RISAF region 14 start-address register
  $388 constant RISAF_RISAF_REG14_ENDR  \ RISAF region 14 end-address register
  $38C constant RISAF_RISAF_REG14_CIDCFGR    \ RISAF region 14 CID configuration register
  $390 constant RISAF_RISAF_REG14_ACFGR \ RISAF region 14 subregion A configuration register
  $394 constant RISAF_RISAF_REG14_ASTARTR    \ RISAF region 14 subregion A start-address register
  $398 constant RISAF_RISAF_REG14_AENDR \ RISAF region 14 subregion A end-address register
  $39C constant RISAF_RISAF_REG14_ANESTR    \ RISAF region 14 subregion A nested mode register
  $3A0 constant RISAF_RISAF_REG14_BCFGR \ RISAF region 14 subregion B configuration register
  $3A4 constant RISAF_RISAF_REG14_BSTARTR    \ RISAF region 14 subregion B start-address register
  $3A8 constant RISAF_RISAF_REG14_BENDR \ RISAF region 14 subregion B end-address register
  $3AC constant RISAF_RISAF_REG14_BNESTR    \ RISAF region 14 subregion B nested mode register
  $3C0 constant RISAF_RISAF_REG15_CFGR  \ RISAF region 15 configuration register
  $3C4 constant RISAF_RISAF_REG15_STARTR    \ RISAF region 15 start-address register
  $3C8 constant RISAF_RISAF_REG15_ENDR  \ RISAF region 15 end-address register
  $3CC constant RISAF_RISAF_REG15_CIDCFGR    \ RISAF region 15 CID configuration register
  $3D0 constant RISAF_RISAF_REG15_ACFGR \ RISAF region 15 subregion A configuration register
  $3D4 constant RISAF_RISAF_REG15_ASTARTR    \ RISAF region 15 subregion A start-address register
  $3D8 constant RISAF_RISAF_REG15_AENDR \ RISAF region 15 subregion A end-address register
  $3DC constant RISAF_RISAF_REG15_ANESTR    \ RISAF region 15 subregion A nested mode register
  $3E0 constant RISAF_RISAF_REG15_BCFGR \ RISAF region 15 subregion B configuration register
  $3E4 constant RISAF_RISAF_REG15_BSTARTR    \ RISAF region 15 subregion B start-address register
  $3E8 constant RISAF_RISAF_REG15_BENDR \ RISAF region 15 subregion B end-address register
  $3EC constant RISAF_RISAF_REG15_BNESTR    \ RISAF region 15 subregion B nested mode register

: RISAF_DEF ; [then]
